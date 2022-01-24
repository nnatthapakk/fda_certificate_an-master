app.controller('FRM_SELECT_LCN_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();

    pageload();

    function pageload() {

        var CITIZEN_ID_AUTHORIZE = sessionStorage.CITIZEN_ID_AUTHORIZE;

        //var DataLCN = CENTER_SV.SP_MAINCOMPANY_IDENTIFY(CITIZEN_ID_REPLACEMENT);
        //DataLCN.then(function (datas) {
        //    $scope.DATA_LCN = datas.data;
        //});

        var Getdata = CENTER_SV.SP_GET_CER_DRUG_LCN(CITIZEN_ID_AUTHORIZE);
        Getdata.then(function (datas) {
            $scope.LIST_LCN = datas.data;           
        });


        //If txt_namep.Text <> "" Then
        //chk_name = 1
        //End If
        //If txt_rgtno.Text <> "" Then
        //chk_rgtno = 1
        //End If
     
    };

    $scope.SELECT_LCN = function (datas) {
        REDIRECT('/FRM_CERTIFICATE_CPP/FRM_SELECT_REGISTER');
    };

    $scope.SELECT_DATA = function (datas) {
        REDIRECT('/FRM_CERTIFICATE_CPP/FRM_CPP_MAIN');
    };
  
   
}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}

