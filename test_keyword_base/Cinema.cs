using System;

namespace Base_teste
{
    class Cinema:Entertainment
    {
        private string movie;
        private string genre = "desconhecido";
        private byte age_rating = 0;

        #region Properties
        public string Movie 
        {
            get { return this.movie; }
            set { this.movie = value; }
        }
        public string Genre 
        {
            get { return this.genre; }
            set { this.genre = value; }
        }
        public byte Age_rating 
        {
            get { return this.age_rating; }
            set { this.age_rating = value > 18 ? (byte)0 : value; }
        }
        #endregion

        #region Constructors
        public Cinema(string movie, string gender, byte age_rating, 
                      string entertainment_type = "Cinema", string largest_audience = "Todos")
                      : base(entertainment_type, largest_audience)
        {
            this.movie = movie;
            this.genre = gender;
            this.Age_rating = age_rating;
        }

        public Cinema(string movie, string gender): base()
        {
            this.movie = movie;
            this.genre = gender;
        }

        public Cinema(string movie): base()
        {
            this.movie = movie;
        }
        #endregion

        public override void GetInfos()
        {
            base.GetInfos();
            Console.WriteLine("Nome do filme: {0};", movie);
            Console.WriteLine("Gênero: {0};", genre);
            Console.WriteLine("Classificação indicativa: {0};", age_rating == 0 ? "Não informada/Não válida" : age_rating.ToString());
        }
    }
}
