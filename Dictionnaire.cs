using System;

public class Dictionnaire
{
	private string[][] mots; // tableau de tableau des mots du dictionnaire
	public Dictionnaire(string cheminFichier)
	{
		ChargerMots(cheminFichier);
	}

	private void ChargerMots(string cheminFichier) //Constructeur 
    {
        try
        {
			string[] lignes = File.ReadAllLines(cheminFichier);
			motsParLettres = new string[lignes.Length][]; //initialistion

			for(int i = 0; i<lignes.Length; i++)
            {
				motsParLettre[i] = lignes[i].Trim().Split(' '); //trim nettoie les espaces au debut et a la fin. split sépare la chaine a chaque espace et en fait un tableau
				
            }
        }
		catch (IOException e)
        {
			Console.WriteLine("Une erreur est survenue lors de la lecture du fichier: " + e.Message);
        }
    }
}
