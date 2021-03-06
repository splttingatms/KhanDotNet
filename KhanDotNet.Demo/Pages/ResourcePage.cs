﻿using EasyConsole;

namespace KhanDotNet.Demo.Pages
{
    class ResourcePage : MenuPage
    {
        public ResourcePage(Program program)
            : base("Resources", program)
        {
            Menu.Add("Badges", () => program.NavigateTo<BadgePage>());
            Menu.Add("Exercises", () => program.NavigateTo<ExercisePage>());
            Menu.Add("Topics", () => program.NavigateTo<TopicPage>());
            Menu.Add("Topic Tree", () => program.NavigateTo<TopicTreePage>());
            Menu.Add("Users", () => program.NavigateTo<UserPage>());
        }
    }
}
