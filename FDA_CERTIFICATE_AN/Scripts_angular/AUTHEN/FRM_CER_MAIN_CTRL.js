app.controller('FRM_CER_MAIN_CTRL', function ($scope, CENTER_SV, $http, $location) {

   
    $scope.loading = true;

   
    $scope.DOC_ID = 0;
    $scope.DOC_TITLE = "TEST";
    $scope.IS_USE = 0;
    $scope.rcvno = '';
    $scope.ref_code = '';
    $scope.cpp = '';
    $scope.cpp1 = '';
    $scope.cpp5 = '';
    $scope.cfs = '';

    $scope.Pageload = function (KEY) {

        if (KEY == 'MAIN') {
            var getdata = CENTER_SV.SP_GET_DATA_CER_ALL($scope.rcvno, $scope.ref_code);
            getdata.then(function (datas) {
                $scope.LIST_CER = datas.data;

            }, function () { });

            var Datacpp = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950002');
            Datacpp.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cpp = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datacpp1 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950003');
            Datacpp1.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cpp1 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datacpp5 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950004');
            Datacpp5.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cpp5 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datacfs = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950001');
            Datacfs.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.cfs = $scope.RCV_CER[0].count_cer;
            }, function () { });
            //listree();

            var Datalorpor2 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950102');
            Datalorpor2.then(function (datas) {
                $scope.RCV_CER = datas.data;
                $scope.lorpor2 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datalorpor3 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950103');
            Datalorpor3.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.lorpor3 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datalorpor4 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950104');
            Datalorpor4.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.lorpor4 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datalorpor5 = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950105');
            Datalorpor5.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.lorpor5 = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var DataGMP = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950005');
            DataGMP.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.gmp = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var DataGDP = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950015');
            DataGDP.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.gdp = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var DataGPP = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950016');
            DataGPP.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.gpp = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datachormor = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950202');
            Datachormor.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.chormor = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datachorsor = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950203');
            Datachorsor.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.chorsor = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datachorwor = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950201');
            Datachorwor.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.chorwor = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datatranmodern = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950007');
            Datatranmodern.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.modern = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datatranimport = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950008');
            Datatranimport.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.import = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datatranmanufac = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950009');
            Datatranmanufac.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.manufac = $scope.RCV_CER[0].count_cer;
            }, function () { });

            var Datatranplace = CENTER_SV.SP_GET_CER_DRUG_ALL_RCV('950010');
            Datatranplace.then(function () {
                $scope.RCV_CER = datas.data;
                $scope.place = $scope.RCV_CER[0].count_cer;
            }, function () { });
        }

        else if (KEY == 'LCN') {
            alert();
        }

    };

    $scope.DATA_CPP = function (PROCESS_ID) {
        var getdata = CENTER_SV.SP_GET_CER_DRUG_APPROVED_PROCESS(PROCESS_ID);
        getdata.then(function (datas) {
            $scope.LIST_CER = datas.data;

            //sessionStorage.PROCESS_ID = PROCESS_ID;
        }, function () { });
    };

    $scope.BTN_Search = function (CITIZEN_ID) {
        sessionStorage.CITIZEN_ID_REPLACEMENT = CITIZEN_ID;
        var url = "/LCN/FRM_SELECT_LCN";
        REDIRECT(url);
    };

    $scope.SELECT_LCN = function (datas) {
        sessionStorage.PROCESS_ID = datas.FK_PROCESS_ID;
        REDIRECT('/AUTHEN/FRM_CERTIFICATE_STAFF_CONFIRM');
    };

    $scope.maincpp = function () {
        $scope.CPP_PATH = SET_URL_SV('/AUTHEN/FRM_MAIN_DRUG_STAFF');
    }

    $scope.loadcpp = function () {
        $scope.VW_PATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/VW_OUTPUT_CPP');
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/AUTHEN/FRM_CER_MAIN');
    };

    $scope.BTN_RETURN = function () {
        REDIRECT('/AUTHEN/FRM_RETURN_EDIT');
    };

    $scope.BTN_BACK_CONFIRM = function () {
        REDIRECT('/AUTHEN/FRM_CERTIFICATE_STAFF_CONFIRM');
    };

    $scope.BTN_WORK_GROUP = function () {
        REDIRECT('/AUTHEN/FRM_CHOOSE_WORK_GROUP');
    }

    $scope.BTN_APPOINT = function () {
        REDIRECT('/FRM_CERTIFICATE_CPP/FRM_CERTIFICATE_APPOINTMENT');
    };

    
    $scope.currentPage = 0;
    $scope.paging = {
        total: 10,
        current: 1,
        onPageChanged: loadPages
    };

    function loadPages() {
        console.log('Current page is : ' + $scope.paging.current);

        // TODO : Load current page Data here

        $scope.currentPage = $scope.paging.current;
    }

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}

app.filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});