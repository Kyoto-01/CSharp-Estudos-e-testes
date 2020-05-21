using System;

namespace Base_teste
{
    class Music:Entertainment
    {
        private string music_name;
        private string singer;
        private string genre = "Desconhecido";
        private string sub_genre = "Desconhecido";

        #region Properties
        public string Music_name
        {
            get { return this.music_name; }
            set { this.music_name = value; }
        }
        public string Singer
        {
            get { return this.singer; }
            set { this.singer = value; }
        }
        public string Genre 
        {
            get { return this.genre; }
            set { this.genre = value; }
        }
        public string Sub_genre
        {
            get { return this.sub_genre; }
            set { this.sub_genre = value; }
        }
        #endregion

        #region Constructors
        public Music(string music, string singer, string genre, string sub_genre,
                     string entertainment_type = "Música", string largest_audience = "Todos")
                     :base(entertainment_type, largest_audience)
        {
            this.music_name = music;
            this.singer = singer;
            this.genre = genre;
            this.sub_genre = sub_genre;
        }

        public Music(string music, string singer, string genre): base()
        {
            this.music_name = music;
            this.singer = singer;
            this.genre = genre;
        }

        public Music(string music, string singer): base()
        {
            this.music_name = music;
            this.singer = singer;
        }
        #endregion

        public override void GetInfos()
        {
            base.GetInfos();
            Console.WriteLine("Música: {0};", music_name);
            Console.WriteLine("Cantor: {0};", singer);
            Console.WriteLine("Gênero: {0};", genre);
            Console.WriteLine("Sub-gênero: {0};", sub_genre);
        }
    }
}
