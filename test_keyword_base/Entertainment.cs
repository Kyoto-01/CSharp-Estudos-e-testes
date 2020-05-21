using System;

namespace Base_teste
{
    public abstract class Entertainment
    {
        private const string default_value = "Não informado";
        private string type;
        private string largest_audience;

        #region Properties
        public string Type 
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Largest_audience 
        {
            get { return this.largest_audience; }
            set { this.largest_audience = value; }
        }
        #endregion

        #region Constructors
        public Entertainment(string type, string largest_audience)
        {
            this.type = type;
            this.largest_audience = largest_audience;
        }

        public Entertainment()
        {
            this.type = default_value;
            this.largest_audience = default_value;
        }
        #endregion

        public virtual void GetInfos()
        {
            Console.WriteLine("Tipo de entretenimento: {0};", type);
            Console.WriteLine("Maior público: {0};", largest_audience);
        }
    }
}
