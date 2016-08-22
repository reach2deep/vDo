var app = angular.module("MyApp")
app.controller("appuserCtrl", ['$scope', '$state', '$stateParams', '$modal', '$log', 'AppUserService', function ($scope, $state, $stateParams, $modal, $log, AppUserService) {
           $scope.pageTitle = 'App Users';
           $scope.message = 'Am the app user page';

           $scope.userlist = null;
           $scope.userlist = gerUserlist();
    

           function gerUserlist() {
               AppUserService.getAllUsers()
               .then(function (data) {
                   $scope.userlist = AppUserService.appusers;
               });
           };

}]);
