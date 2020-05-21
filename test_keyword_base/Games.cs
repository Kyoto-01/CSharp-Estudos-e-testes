using System;

namespace Base_teste
{
    class Games:Entertainment
    {
        private string game;
        private bool is_3d;
        private string genre = "Desconhecido";
        private byte age_rating = 0;

        #region Properties
        public string Game 
        {
            get { return this.game; }
            set { this.game = value; }
        }
        public bool Is_3d 
        {
            get { return this.Is_3d; }
            set { this.Is_3d = value; }
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
        public Games(string game, bool is_3d, string genre, byte age_rating,
                     string entertainment_type = "Games", string largest_audience = "Jovens")
                     : base(entertainment_type, largest_audience)
        {
            this.game = game;
            this.genre = genre;
            this.Age_rating = age_rating;
            this.is_3d = is_3d;
        }

        public Games(string game, bool is_3d, string genre): base()
        {
            this.game = game;
            this.is_3d = is_3d;
            this.genre = genre;
        }

        public Games(string game, bool is_3d): base()
        {
            this.game = game;
            this.is_3d = is_3d;
        }
        #endregion

        public override void GetInfos()
        {
            base.GetInfos();
            Console.WriteLine("Nome do game: {0};", game);
            Console.WriteLine("Gráfico: {0};", is_3d == true ? "3D" : "2D");
            Console.WriteLine("Gênero: {0};", genre);
            Console.WriteLine("Classificação indicativa: {0};", age_rating == 0 ? "Não informada/Não válida" : age_rating.ToString());
        }
    }
}
