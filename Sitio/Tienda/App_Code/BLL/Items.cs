using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;


/// <summary>
/// Descripción breve de Items
/// </summary>
/// 
namespace BLL
{ 
public class Items
{
    public Items()
    {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
           
        }
        public static long InsertItem(ItemInfo info)
        {

            Item Item = new Item();

            Item.FechaCreacion = DateTime.Now;

            Item.IDItem = info.IDItem;
            Item.Codigo = info.Codigo;
            Item.Descripcion = info.Descripcion;
            Item.Titulo = info.Titulo;


            Item.Grupo = info.Grupo;
            Item.SubGrupo = info.SubGrupo;
            Item.Marca = info.Marca;

            Item.PalabrasClave = info.PalabrasClave;

            Item.Publicado = info.Publicado;
            Item.Recomendado = info.Recomendado;
            Item.LoNuevo = info.LoNuevo;

            Item.Precio = info.Precio;

            Item.Orden = info.Orden;

            DataClassesDataContext dc = new DataClassesDataContext();


            dc.Item.InsertOnSubmit(Item);
            dc.SubmitChanges();

            return Item.IDItem;
        }
    }
   
        
    public class ItemInfo
    {

        public long IDItem { get; set; }
        public DateTime FechaCreacion { get; set; }

        public string Codigo { get; set; }
        public string Titulo { get; set; }

        public string Descripcion { get; set; }
        public string PalabrasClave { get; set; }

        public long Orden { get; set; }


        public string Grupo { get; set; }
        public string SubGrupo { get; set; }
        public string Marca { get; set; }

        public bool Publicado { get; set; }
        public bool Recomendado { get; set; }
        public bool LoNuevo { get; set; }

        public decimal Precio { get; set; }


    }
}