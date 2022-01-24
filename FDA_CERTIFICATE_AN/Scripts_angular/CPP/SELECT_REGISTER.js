app.controller('SELECT_REGISTER', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    var CITIZEN = CITIZEN_ID_AUTHORIZE;
    var IDA = sessionStorage.IDA;
    var IDENTIFY = IDENTIFY;

    pageload();

    function pageload() {
        //var Getdata1 = CENTER_SV.SP_GET_DRUG_drrgt_search_newcode_not(newcode_not, name, rgtno, 1, 1);
        //Getdata1.then(function (datas) {
        //    $scope.LIST_DATA = datas.data;
        //});

        var Getdata1 = CENTER_SV.SP_MAINCOMPANY_IDENTIFY(CITIZEN);
        Getdata1.then(function (datas) {
            $scope.DATA = datas.data;
        });

        var Getdata2 = CENTER_SV.SP_GET_DRUG_LCN_IDA(IDA);
        Getdata2.then(function (datas) {
            $scope.LCN_DATA = datas.data;
        });
    };

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}