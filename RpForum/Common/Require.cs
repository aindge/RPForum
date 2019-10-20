using System;
using RpForum.ViewModels;

namespace RpForum.Common
{
    public static class Require
    {
        public static void NotNull(object obj, string message = null)
        {
            if(obj is null) throw new InvalidOperationException(message ?? "A required object was null.");
        }

        public static void IsValid(CommandViewModel viewModel)
        {
            if(!viewModel.IsValid) throw new InvalidOperationException(@"The view model provided isn't valid or hasn't been validated.");
        }
    }
}