using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion.Application.DTOs.Categories
{
    public record CategoryItemDto( int Id,string Name);

    //public record CategoryItemDto
    //{
    //    public int Id { get; init; }
    //    public string Name { get; init; }
    //    public CategoryItemDto(int id,string name)
    //    {
    //        Id = id;
    //        Name = name;
    //    }
    //}
}
