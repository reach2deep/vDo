angular.module("MyApp")
       .controller("appuserCtrl", ['$scope', function ($scope) {
           $scope.pageTitle = 'App Users';
           $scope.message = 'Am the app user page';
       }]);
