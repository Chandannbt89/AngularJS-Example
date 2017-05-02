var app = angular.module('MyApp', []);

app.controller('menuController', ['$scope', '$http', function ($scope, $http) {
    $scope.SiteMenu = [];
    $http.get('/Data/GetSiteMenu').then(function (data) {
        $scope.SiteMenu = data.data;
    }, function (error) {
        alert('Error');
    })
}]);
 