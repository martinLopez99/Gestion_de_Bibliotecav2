using System;

namespace Gestion_de_Bibliotecav2.Dominio
{
	public class Categoria
	{
		private int iID;
		private string iNombre;

		public Categoria(string pNombre)
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
