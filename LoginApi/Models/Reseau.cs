﻿using System;
using System.Collections.Generic;

namespace LoginApi.Models
{
    public class Reseau
    {
        public int reseauId { get; set; }
        public string reseauSocial { get; set; }
        public string reseauConnexionId { get; set; }

        private Random r = new Random(1);
        private const int minValueReseau = 1;
        private const int maxValueReseau = 10;

        public Reseau(string reseauSocial, string reseauConnexionId)
        {
            reseauId = r.Next(minValueReseau, maxValueReseau);
            this.reseauSocial = reseauSocial;
            this.reseauConnexionId = reseauConnexionId;
        }
    }
}