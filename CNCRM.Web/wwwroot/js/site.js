



var app = angular.module("CNCRM", ["ngRoute"]);
//burada yazan url api servisin adresi
var serverUrl = "http://localhost:65402/";

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "Home/Index"
        })
        .when("/BackupUnit", {
            templateUrl: "Home/BackupUnit"
        })
        .when("/Customer", {
            templateUrl: "Home/Customer"
        })
        .when("/Test", {
            templateUrl: "Home/Test"
        })
        .when("/User", {
            templateUrl: "Home/UserPage"
        });
});

//buradan sonra yazacagim seylerin goruntulerini almam lazim


app.controller("BackupUnitController", function ($http, $window, $scope) {
    $scope.init = function () {
        $http({
            method: "Get",
            url: `${serverUrl}BackupUnit/GetAll`
        })
            .then(function (response) {
                $scope.backupUnitList = response.data.data;
            });
    }

    $scope.getCustomerData = function () {
        $http({
            method: "Get",
            url: `${serverUrl}Customer/GetAll`
        })
            .then(function (response) {
                $scope.customerList = response.data.data;
            })
    }

    $scope.addBackupUnit = function () {
        $http({
            method: "Post",
            url: `${serverUrl}BackupUnit/InsertAndComplete`,
            data: {
                "createdOn": "string",
                "modifiedOn": "string",
                "brand": $scope.backupUnit.brand,
                "model": $scope.backupUnit.model,
                "serialNumber": $scope.backupUnit.serialNumber,
                "cpu": $scope.backupUnit.cpu,
                "ram": $scope.backupUnit.ram,
                "diskModel": $scope.backupUnit.diskModel,
                "diskCapacity": $scope.backupUnit.diskCapacity,
                "totalDiskSlot": $scope.backupUnit.totalDiskSlot,
                "raidType": $scope.backupUnit.raidType,
                "raidUpTo": $scope.backupUnit.raidUpTo,
                "customerId": $scope.backupUnitCustomerCompanyName.id
            }
        })
            .then(function successCallBack(response) {
                alert("Success...")
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("Error..." + response.status);
                });
    }

    $scope.updateBackupUnit = function () {
        $http({
            method: "Put",
            url: `${serverUrl}BackupUnit/UpdateAndComplete`,
            data: {
                "createdOn": "string",
                "modifiedOn": "string",
                "brand": $scope.backupUnits.brand,
                "model": $scope.backupUnits.model,
                "serialNumber": $scope.backupUnits.serialNumber,
                "cpu": $scope.backupUnits.cpu,
                "ram": $scope.backupUnits.ram,
                "diskModel": $scope.backupUnits.diskModel,
                "diskCapacity": $scope.backupUnits.diskCapacity,
                "totalDiskSlot": $scope.backupUnits.totalDiskSlot,
                "raidType": $scope.backupUnits.raidType,
                "raidUpTo": $scope.backupUnits.raidUpTo,
                "customerId": $scope.backupUnitCustomerCompanyName.id
            }
        })
            .then(function successCallBack(response) {
                alert("Success...")
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("Error..." + response.status);
                });
    }

    $scope.fetchUpdateDataForBackupUnit = function (backupUnit) {
        $scope.backupUnits = {
            "id": backupUnit.id,
            "createdOn": "string",
            "modifiedOn": "string",
            "brand": backupUnit.brand,
            "model": backupUnit.model,
            "serialNumber": backupUnit.serialNumber,
            "cpu": backupUnit.cpu,
            "ram": backupUnit.ram,
            "diskModel": backupUnit.diskModel,
            "diskCapacity": backupUnit.diskCapacity,
            "totalDiskSlot": backupUnit.totalDiskSlot,
            "raidType": backupUnit.raidType,
            "raidUpTo": backupUnit.raidUpTo,
            "customerId": backupUnit.customerId,
        }
    }

    $scope.deleteBackupUnit = function (backupUnitId) {
        $http({
            method: "Delete",
            url: `${serverUrl}BackupUnit/DeleteAndComplete`,
            data: {
                "id": backupUnitId
            },
            headers: {
                "content-type": "application/json"
            }
        })
            .then(function successCallBack(response) {
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("Error..." + response.status);
                });
    }
});

app.controller("CustomerController", function ($scope, $window, $http) {
    $scope.init = function () {
        $http({
            method: "Get",
            url: `${serverUrl}Customer/GetAll`
        })
            .then(function (response) {
                $scope.customerList = response.data.data;
            });

        $scope.getById = function (customerId) {
            $http({
                method: "Get",
                url: `${serverUrl}Customer/GetById?id=${customerId}`
            })
                .then(function (response) {
                    $scope.getCustomer = response.data.data;
                });
        }
    }

    $scope.addCustomer = function () {
        $http({
            method: "Post",
            url: `${serverUrl}Customer/InsertAndComplete`,
            data:
            {
                "type": $scope.customer.type,
                "companyName": $scope.customer.companyName,
                "city": $scope.customer.city,
                "address": $scope.customer.address,
                "email": $scope.customer.email,
                "phone": $scope.customer.phone,
                "fax": $scope.customer.fax,
                "contactName": $scope.customer.contactName,
                "mobile": $scope.customer.mobile,
                "sectorName": $scope.customer.sectorName,
                "taxNumber": $scope.customer.taxNumber,
                "taxOffice": $scope.customer.taxOffice,
                "webSite": $scope.customer.webSite,
                "postCode": $scope.customer.postCode
            }
        })
            .then(function successCallBack(response) {
                alert("Success...")
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("Error..." + response.status);
                });
    }

    $scope.fetchUpdateDataForCustomer = function (customer) {
        $scope.customers = {
            "id": customer.id,
            "createdOn": "string",
            "modifiedOn": "string",
            "type": customer.type,
            "companyName": customer.companyName,
            "city": customer.city,
            "address": customer.address,
            "email": customer.email,
            "phone": customer.phone,
            "fax": customer.fax,
            "contactName": customer.contactName,
            "mobile": customer.mobile,
            "sectorName": customer.sectorName,
            "taxNumber": customer.taxNumber,
            "taxOffice": customer.taxOffice,
            "webSite": customer.webSite,
            "postCode": customer.postCode
        }
    }


    $scope.updateCustomer = function (customerId) {
        $http({
            method: "Put",
            url: `${serverUrl}Customer/UpdateAndComplete`,
            data: {
                "id": customerId,
                "createdOn": "string",
                "modifiedOn": "string",
                "type": $scope.customers.type,
                "companyName": $scope.customers.companyName,
                "city": $scope.customers.city,
                "address": $scope.customers.address,
                "email": $scope.customers.email,
                "phone": $scope.customers.phone,
                "fax": $scope.customers.fax,
                "contactName": $scope.customers.contactName,
                "mobile": $scope.customers.mobile,
                "sectorName": $scope.customers.sectorName,
                "taxNumber": $scope.customers.taxNumber,
                "taxOffice": $scope.customers.taxOffice,
                "webSite": $scope.customers.webSite,
                "postCode": $scope.customers.postCode
            }
        })
            .then(function successCallBack(response) {
                alert("Updated successfully...")
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("Error" + response.status);
                    console.log(response.data);
                });
    }

    $scope.deleteCustomer = function (customerId) {
        $http({
            method: "Delete",
            url: `${serverUrl}Customer/DeleteAndComplete`,
            data: {
                "id": customerId
            },
            headers: {
                "content-type": "application/json"
            }
        })
            .then(function successCallBack(response) {
                alert("Deleted successfully...")
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("Error" + response.status);
                    console.log(response.data);
                });
    }

    $scope.addUser = function () {
        $http({
            method: "Post",
            url: `${serverUrl}User/InsertAndComplete`,
            data: {
                "createdOn": "string",
                "modifiedOn": "string",
                "firstName": $scope.userFirstName,
                "lastName": $scope.userLastName,
                "departmentName": $scope.userDepartmentName,
                "email": $scope.userEmail,
                "canVpnAccess": $scope.userCanVpnAccess,
                "customerId": $scope.backupUnitCustomerCompanyName.id
            }
        }).
            then(function successCallBack() {
                alert("Successful...");
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("Error..." + response.status);
                });
    }

    $scope.getAllUser = function () {
        $http({
            method: "Get",
            url: `${serverUrl}User/GetAll`
        })
            .then(function successCallBack(response) {
                $scope.userList = response.data.data;
            },
                function errorCallBack(response) {
                    alert("Error...", response.status);
                })
    }

    $scope.fetchUpdateDataForUser = function (user) {
        $scope.users = {
            "firstName": user.firstName,
            "lastName": user.lastName,
            "departmentName": user.departmentName,
            "email": user.email,
            "canVpnAccess": user.canVpnAccess,
            "customerId": user.customerId,
            "id": user.id,
            "createdOn": "string",
            "modifiedOn": "string"
        }
    }

    $scope.updateUser = function (userId) {
        $http({
            method: "Put",
            url: `${serverUrl}User/UpdateAndComplete`,
            data: {
                "id": userId,
                "createdOn": "string",
                "modifiedOn": "string",
                "firstName": $scope.users.firstName,
                "lastName": $scope.users.lastName,
                "departmentName": $scope.users.departmentName,
                "email": $scope.users.email,
                "canVpnAccess": $scope.users.canVpnAccess,
                "customerId": $scope.users.customerId
            },
            headers: {
                "content-type": "application/json"
            }
        })
            .then(function successCallBack(response) {
                alert("success...");
                $window.location.reload()
            },
                function errorCallBack(response) {
                    alert("error..." + response.status)
                })
    }


    $scope.deleteUser = function (user) {
        $http({
            method: "Delete",
            url: `${serverUrl}User/DeleteAndComplete`,
            data: {
                "id": user.id
            },
            headers: {
                "content-type": "application/json"
            }
        })
            .then(function successCallBack() {
                alert("delete successfully...")
                $window.location.reload();
            },
                function errorCallBack(response) {
                    alert("error..." + response.status);
                })
    }
});


app.directive('ngConfirmClick', [
    function () {
        return {
            link: function (scope, element, attr) {
                var msg = attr.ngConfirmClick || "Are you sure?";
                var clickAction = attr.confirmedClick;
                element.bind('click', function (event) {
                    if (window.confirm(msg)) {
                        scope.$eval(clickAction)
                    }
                });
            }
        };
    }])

