var app = angular.module('mode', [])

app.controller('login', function ($scope,$http) {

    $scope.log = function () {
        $http.get('http://localhost:55985/Home/Index').
     success(function (response) {
         console.log(response)
     });
    }
});

