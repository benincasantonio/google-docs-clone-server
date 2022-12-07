using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace GoogleDocsCloneServer.Entities
{
    public class Document
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public JsonDocument? Content { get; set; }
    }
}
