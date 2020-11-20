﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Business;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Data;
using System.Runtime.CompilerServices;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace ModelLayer.Data
{
    class DaoUtilisateur
    {
        private Dbal mydbal;
        private DaoUtilisateur theDaoUser;

        public DaoUtilisateur(Dbal dbal, DaoUtilisateur DaoUser)
        {
            this.mydbal = dbal;
            this.theDaoUser = DaoUser;
        }

        public void Insert(Utilisateur unUser)
        {
            string query = "Utilisateur (id, role, idVille, identifiant, mdp) VALUES ("
                + unUser.Id + ",'"
                + unUser.Role + "',"
                + unUser.Ville.Id + ",'"
                + unUser.Identifiant.Replace("'", "''") + ","
                + unUser.Mdp.Replace("'", "''") + ")";
            this.mydbal.Insert(query);

        }

        public void Update(Utilisateur unUser)
        {
            string query = "Utilisateur Set id= " + unUser.Id
                + ", role = '" + unUser.Role
                + ", ville = " + unUser.Ville.Id
                + ", identifiant = '" + unUser.Identifiant.Replace("'", "''")
                + ", mdp = '" + unUser.Mdp.Replace("'", "''");
            this.mydbal.Update(query);
        }

        public void Delete(Utilisateur unUser)
        {
            string query = "Utilisateur Where id = " + unUser.Id;
            this.mydbal.Delete(query);
        }

        public List<Utilisateur> SelectAll()
        {
            List<Utilisateur> listUtilisateur = new List<Utilisateur>();
            DataTable myTable = this.mydbal.SelectAll("Utilisateur");

            foreach (DataRow r in myTable.Rows)
            {
                listUtilisateur.Add(new Utilisateur(
                    (int)r["id"],
                    (char)r["role"],
                    (Ville)r["Ville"],
                    (string)r["identifiant"],
                    (string)r["mdp"]));
            }
            return listUtilisateur;
        }

        public Utilisateur SelectbyId(int id)
        {
            DataRow rowUtilisateur = this.mydbal.SelectById("utilisateur", id);
            return new Utilisateur((int)rowUtilisateur["id"],(char)rowUtilisateur["role"])
        }
    }
}
