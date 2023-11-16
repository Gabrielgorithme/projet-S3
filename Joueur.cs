namespace projet-S3
{
    internal class Joueur
    {
        string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        int mots;
        public int Mots
        {
            get { return mots;}
            set { mots = value; }
        }
        int score;
        public int Score
        {
            get { return score;}
            set { score = value; }
        }

        public Joueur(string nom, int mots, int score)
        {
            this.nom = nom;
            this.mots = mots;
            mots = 0;
            this.score = score;
            score = 0;
        }
        List<string> listemots = new List<string>(); //tableau dynamique qui va contenir les mots trouvés 
        /// <summary>
        /// Ajoute le mot trouvé par le joueur au tableau dynamique 
        /// </summary>
        /// <param name="mot">utlisation de la méthode .Add pour ajouter le mot</param>
        public void Add_mot(string mot)
        {
            listemots.Add(mot);
        }
        /// <summary>
        /// Renvoie une chaine de charactère qui donne les information du joueur
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return "Nom du joueur :" + nom + "\nNombre de mots trouvés :" + "\nScore :" + score;
        }
        /// <summary>
        /// Ajoute une valeur au score
        /// </summary>
        /// <param name="val"></param>
        public void Add_score(int val)
        {
            score = score + val;
        }
        /// <summary>
        /// Cherche dans le tableau dynamique si le mot existe, c'est-à-dire si le mot à déjà été trouvé
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public bool Contient(string mot)
        {
            return listemots.Contains(mot);
        }
       
    }
}