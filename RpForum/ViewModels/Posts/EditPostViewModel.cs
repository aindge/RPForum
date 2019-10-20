using FluentValidation;
using RpForum.Entities;

namespace RpForum.ViewModels.Posts
{
    public class EditPostViewModel : CommandViewModel
    {
        public EditPostViewModel() { }

        public EditPostViewModel(Post post)
        {
            Id = post.Id;
            Content = post.Content;
        }

        public int Id { get; set; }

        public string Content { get; set; }
    }

    public class EditPostViewModelValidator : AbstractValidator<EditPostViewModel>
    {
        public EditPostViewModelValidator()
        {
            RuleFor(vm => vm.Id).GreaterThan(0);
            RuleFor(vm => vm.Content).NotEmpty();
        }
    }
}