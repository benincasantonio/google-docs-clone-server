using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace GoogleDocsCloneServer.Entities
{
    public class Document
    {
        public Guid Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public JsonDocument? Content { get; set; }
    }
}
