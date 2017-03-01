using System;

namespace Collectively.Messages.Events.Remarks.Models
{
    public class RemarkCategory
    {
        public Guid CategoryId { get; }
        public string Name { get; }

        protected RemarkCategory()
        {
        }

        public RemarkCategory(Guid categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }
    }
}