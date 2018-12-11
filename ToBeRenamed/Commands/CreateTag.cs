using MediatR;
using ToBeRenamed.Dtos;

namespace ToBeRenamed.Commands
{
    public class CreateTag : IRequest<TagDto>
    {
        public int Id { get; }
        public string Tag { get; }

        public CreateTag(int id, string tag)
        {
            Id = id;
            Tag = tag;
        }
    }
}
