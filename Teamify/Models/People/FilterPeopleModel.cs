using System.Collections.Generic;
using Teamify.Models.Shared;

namespace Teamify.Models.People
{
    public class FilterPeopleModel
    {
        public string Filter { get; set; }
        public IList<SelectModel<string, int>> FilterOut { get; set; }
    }
}