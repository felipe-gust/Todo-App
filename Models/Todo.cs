using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("\nTítulo")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set; } = "";

        [DisplayName("\nConcluído")]
        public bool Done { get; set; }

        [DisplayName("\nCriado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("\nÚltima atualização")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public string User { get; set; } = "";
    }
}