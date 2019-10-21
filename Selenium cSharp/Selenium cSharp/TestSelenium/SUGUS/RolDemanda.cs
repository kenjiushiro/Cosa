using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUGUS
{
    public class RolDemanda
    {
        #region Atributos y constructores

        private string cliente;
        private string specialty;
        private string projectID;

        public RolDemanda(string id, string cliente, string specialty)
        {
            this.projectID = id;
            this.cliente = cliente;
            this.specialty = specialty;
        }
        #endregion

        #region Propiedades
        public string Cliente
        {
            get
            {
                return this.cliente;
            }
        }

        public string ID
        {
            get
            {
                return this.projectID;
            }
        }

        public string Specialty
        {
            get
            {
                return this.specialty;
            }
        }
        #endregion

        public static Queue<RolDemanda> operator +(Queue<RolDemanda>queue, RolDemanda rol)
        {
            queue.Enqueue(rol);
            return queue;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("ID: " + this.ID);
            retorno.AppendLine("Cliente: " + this.cliente);
            retorno.AppendLine("Specialty: " + this.specialty);

            return retorno.ToString();
        }

        //public static implicit operator string(RolDemanda rol)
        //{
            

        //}
    }
}
