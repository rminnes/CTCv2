
namespace CTCv2.Models.ViewModels.Himu
{
    public interface IPanel 
    {
         int Id { get; set; }
         string Title { get; set; }
         string Text { get; set; }
         string MenuTitle { get; set; }
         bool HasMenuItem { get; set; }
         int Order { get; set; }

  
    }
}