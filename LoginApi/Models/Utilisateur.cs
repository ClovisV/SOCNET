using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApi.Models
{
    public class Utilisateur
    {
        public int utilisateurId { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public List<Reseau> reseaux { get; set; }

        private Random r = new Random(1);
        private const int minValueUtilisateur = 1;
        private const int maxValueUtilisateur = 100;

        public Utilisateur(string name, string password, List<Reseau> reseaux)
        {
            utilisateurId = r.Next(minValueUtilisateur, maxValueUtilisateur);
            this.name = name;
            this.password = password;
            this.reseaux = reseaux;
        }

    }
}