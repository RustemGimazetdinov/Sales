/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.AddEditCustomerItem.created = function (screen) {
    // Write code here.
    screen.details.displayName = "Добавление нового клиента";
    screen.CustomerItem.FName = "Петр";
    screen.findContentItem("Email").isVisible = false;
};