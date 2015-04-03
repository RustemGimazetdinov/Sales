/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.BrowseCitySet.CityItemList_postRender = function (element, contentItem) {
    // Write code here.

    var html = $("<a href='http://yandex.ru'>click me</a>");
    html.prependTo($(element));
};
myapp.BrowseCitySet.Group2_postRender = function (element, contentItem) {
    // Write code here.

};
myapp.BrowseCitySet.DeleteCustomer_execute = function (screen) {
    // Write code here.
    screen.showPopup("ConfirmDelete");
    


//myapp.applyChanges();
};
myapp.BrowseCitySet.MethodNo_execute = function (screen) {
    // Write code here.
    screen.closePopup("ConfirmDelete");
};
myapp.BrowseCitySet.MethodYes_execute = function (screen) {
    // Write code here.
    screen.CitySet.selectedItem.deleteEntity();
    myapp.applyChanges();
    //myapp.navigateBack();
};
myapp.BrowseCitySet.beforeApplyChanges = function (screen) {
    // Write code here.

};
myapp.BrowseCitySet.Method_execute = function (screen) {
    // Write code here.
    for (var i = 0; i < screen.CitySet.count; i++) {
        var city = screen.CitySet.data[i];
        city.CityName = city.CityName + "New";
    }
   
};
myapp.BrowseCitySet.ShowCityItemList_postRender = function (element, contentItem) {
    // Write code here.
    

};