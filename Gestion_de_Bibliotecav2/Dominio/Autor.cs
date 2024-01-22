using System;
using System.Collections.Generic;

namespace Gestion_de_Bibliotecav2.Dominio
{
	public class Autor
	{
		private int iID;
		private string iNombre;

		public Autor(){}

        public Autor(string pNombre)
		{
			iNombre = pNombre;
		}

		public int ID
		{
			get { return this.iID; }
			set { this.iID = value; }
		}

		public string Nombre
		{
			get { return this.iNombre; }
			set { this.iNombre = value; }
		}
	}
}
