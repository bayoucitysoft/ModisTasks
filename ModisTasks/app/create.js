(function () {
    'use strict';
    angular.module('app').controller('Create', create);

    function create($http) {
        var vm = this;
        var dataService = $http;
        
        vm.submitSample = submitSample;

        vm.barcodeInput = '';
        vm.statuses = [];
        vm.statusInput = {
            selectedStatus: {
                Status: ''
            }
        };
        vm.users = [];
        vm.userInput = {
            selectedUser: {
                FullName: ''
            }
        };

        statusList();
        userList();

        function statusList() {
            dataService.get('/api/status')
            .then(function (result) {
                vm.statuses = result.data;
            }, function (error) {
                handleException(error);
            });
        }

        function userList() {
            dataService.get('/api/users')
            .then(function (result) {
                vm.users = result.data;
            }, function (error) {
                handExeception(error);
            });
        }

        function submitSample() {
            var fullName = vm.userInput.selectedUser.FullName.split(' ');
            var d = new Date();
            var data = {
                Status: vm.statusInput.selectedStatus.Status,
                FirstName: fullName[0],
                LastName: fullName[1],
                Barcode: vm.barcodeInput,
                CreatedAt: d.getDate().toLocaleString()
            };
            dataService.post('/api/samples?create', data)
            .then(function (result) {
                vm.Message = result.data;
            }, function (error) {
                vm.Message = "Invalid Sample";
            });
        }
    }
})();