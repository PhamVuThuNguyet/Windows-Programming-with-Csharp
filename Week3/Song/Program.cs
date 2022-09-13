namespace Song
{
    class Song
    {
        private string _name { get; }
        private string _time;
        private string _typeList;

        public Song()
        {
        }

        public Song(string typeList, string name, string time)
        {
            _name = name;
            _time = time;
            _typeList = typeList;
        }

        public List<Song> Input()
        {
            Console.Write("Enter number of songs: ");
            var n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Song " + i);

                var data = Console.ReadLine().Split("_");
                var type = data[0];
                var name = data[1];
                var time = data[2];

                Song song = new Song(type, name, time);

                songs.Add(song);
            }

            return songs;
        }

        public void GetSongsOfType(string typeList, List<Song> songs)
        {
            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song._name);
                }
            }

            else
            {
                foreach (var song in songs)
                {
                    if (song._typeList == typeList)
                    {
                        Console.WriteLine(song._name);
                    }
                }
            }
        }
    }

    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            List<Song> songs = song.Input();
            
            song.GetSongsOfType(Console.ReadLine(), songs);
        }
    }
}