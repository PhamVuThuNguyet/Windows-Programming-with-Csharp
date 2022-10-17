namespace Events
{
    public class CustomEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public string Name { get; set; }
    }

    public class EventLogic
    {
        public delegate void CustomEventHandler(Object sender, CustomEventArgs args);

        public event CustomEventHandler CustomEvent;

        public void StartProcess()
        {
            var data = new CustomEventArgs();

            try
            {
                Console.WriteLine("Process Started!");

                Console.WriteLine("Input Event Name: ");

                data.Name = Console.ReadLine();
                data.IsSuccessful = true;

                OnProcessCompleted(data);
            }
            catch (Exception ex)
            {
                data.IsSuccessful = false;
                data.Name = "NULL";
                OnProcessCompleted(data);
            }
        }

        protected virtual void OnProcessCompleted(CustomEventArgs args)
        {
            CustomEvent?.Invoke(this, args);
            Console.WriteLine("Event Name: " + args.Name);
            Console.WriteLine("Process " + (args.IsSuccessful ? "Completed Successfully" : "failed"));
        }
    }


    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            EventLogic eventLogic = new EventLogic();
            eventLogic.StartProcess();
        }
    }
}