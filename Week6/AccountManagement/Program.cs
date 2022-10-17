namespace AccountManagement
{
    class SortByIdHelper : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.AccountId.CompareTo(y.AccountId);
        }
    }

    class SortByNameHelper : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }

    class SortByBalanceHelper : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return x.Balance.CompareTo(y.Balance);
        }
    }

    class Account
    {
        private string _accountId;
        private string _firstName;
        private string _lastName;

        public string AccountId
        {
            get => _accountId;
            set => _accountId = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public float Balance { get; set; }

        public Account()
        {
        }

        public Account(string accountId, string firstName, string lastName, float balance)
        {
            _accountId = accountId;
            _firstName = firstName;
            _lastName = lastName;
            Balance = balance;
        }

        public void Input()
        {
            Console.Write("Enter ID: ");
            AccountId = Console.ReadLine();

            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("Enter Balance: ");
            Balance = float.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine(
                $"Account: {AccountId}, First name: {FirstName}, Last name: {LastName}, Balance: {Balance}");
        }
    }

    class AccountList
    {
        private List<Account> _accounts = new List<Account>();

        public List<Account> Accounts
        {
            get => _accounts;
            set => _accounts = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void NewAccount()
        {
            Account account = new Account();
            account.Input();
            Accounts.Add(account);
        }

        public void Report()
        {
            foreach (var account in Accounts)
            {
                account.Show();
                Console.WriteLine("========================");
            }
        }

        public void SaveFile(string fileName)
        {
            try
            {
                FileStream output = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);

                StreamWriter writer = new StreamWriter(output);

                foreach (var account in Accounts)
                {
                    writer.WriteLine(
                        $"{account.AccountId},{account.FirstName},{account.LastName},{account.Balance}");
                }

                writer.Close();
                output.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFile(string fileName)
        {
            Accounts.Clear();

            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);

                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(",");
                    Account account = new Account(list[0], list[1], list[2], float.Parse(list[3]));
                    Accounts.Add(account);
                }

                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Remove(string name)
        {
            Account acc = Accounts.Find(account => account.FirstName.Equals("Nguyet"));
            var index = Accounts.BinarySearch(acc, new SortByNameHelper());
            Accounts.RemoveAt(index);
        }
    }

    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            AccountList accountList = new AccountList();

            accountList.NewAccount();
            accountList.NewAccount();
            accountList.Report();
            accountList.SaveFile("account.txt");
            accountList.LoadFile("account.txt");
            accountList.Remove("Nguyet");
            accountList.Report();
        }
    }
}