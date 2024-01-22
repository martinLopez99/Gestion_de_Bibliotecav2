using System;
using System.Collections.Generic;

namespace Gestion_de_Bibliotecav2.Dominio
{
	public class Libro
	{
		private int iID;
		private string iISBN;
		private string iNombre;
		private DateTime iFechaPublicacion;
		public Editorial iEditorial;

		//public virtual ICollection<Libro_Autor> Libro_Autor {get; set;}
		//public virtual ICollection<Libro_Categoria> Libro_Categoria { get; set; }

		public Libro() { }

		public Libro(string pISBN, string pNombre, DateTime pFechaPublicacion)
		{
			iISBN = pISBN;
			iNombre = pNombre;
			iFechaPublicacion = pFechaPublicacion;
		}

		public int ID
		{
			get { return this.iID; }
			set { this.iID = value; }
		}

		public string ISBN
		{
			get { return this.iISBN; }
			set {this.iISBN = value; }
		}

		public string Nombre
		{
			get { return this.iNombre; }
			set { this.iNombre = value;}
		}

		public DateTime FechaPublicacion
		{
			get { return this.iFechaPublicacion; }
			set { this.iFechaPublicacion = value; }
		}

		public Editorial Editorial
		{
			get { return this.iEditorial; }
		}
	}
}
