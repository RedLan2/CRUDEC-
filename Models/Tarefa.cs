using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        public Tarefa(int id, string descricao, EnumStatusTarefa status) 
        {
            this.Id = id;
    this.Descricao = descricao;
    this.Status = status;
   
        }
                public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }


}