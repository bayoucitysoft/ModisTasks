(function () {
    'use strict';

    angular.module('app').controller('Main', main);

    function main($http) {
        var vm = this;
        var dataService = $http;
        vm.filterStatus = filterStatus;
        vm.searchUsers = searchUsers;

        vm.samples = [];

        vm.statuses = [];

        vm.userInput = '';
        vm.globalSearch = '';
        vm.statusInput = {
            selectedStatus: {
                Status : ''
            }
        };

        //populate default call to list all samples
        sampleList();
        //populate status drop down menu 
        statusList();

        function sampleList() {
            dataService.get('/api/samples')
            .then(function (result) {
                vm.samples = result.data;
            }, function (error) {
                handleException(error);
            });
        }

        function statusList() {
            dataService.get('/api/status')
            .then(function (result) {
                vm.statuses = result.data;
            }, function (error) {
                handleException(error);
            });
        }

        function filterStatus() {
            dataService.post('/api/samples?status=' + vm.statusInput.selectedStatus.Status)
            .then(function (result) {
                vm.samples = result.data;
            }, function (error) {
                handleException(error);
            });
        }

        function searchUsers() {
            dataService.post('/api/samples?name=' + vm.userInput)
            .then(function (result) {
                vm.samples = result.data;
            }, function (error) {
                handleException(error);
            });
        }

        function handleException(e) {
            alert(e.data.ExceptionMessage);
        }
    }


})();