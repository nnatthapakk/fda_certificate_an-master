app.controller('CPP_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    pageload();
    $scope.SUBPATH = "";

    $scope.currentPage = 0;
    $scope.paging = {
        total: 20,
        current: 1,
        onPageChanged: loadPages
    };
    function loadPages() {
        console.log('Current page is :' + $scope.paging.current);

        // TODO : Load current page Data here

        $scope.currentPage = $scope.paging.current;
    }

    function pageload() {

    };

    $scope.DATA_CPP = function (process) {
        if (process == '950002' || process == '950003' || process == '950004' || process == '950001') {
            if (process == '950002') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP)';
                $scope.process = process;
            } else if (process == '950003') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) แบบ 1 หน้า';
                $scope.process = process;
            } else if (process == '950004') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF A PHARMACEUTICAL PRODUCT(CPP) แบบ 5 หน้า';
                $scope.process = process;
            } else if (process == '950001') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF FREE SALE';
                $scope.process = process;
            }

        } else if (process == '950011' || process == '950012' || process == '950013' || process == '950014') {
            if (process == '950011') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF LOT RELEASE';
                $scope.process = process;
            } else if (process == '950012') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF LOT RELEASE';
                $scope.process = process;
            } else if (process == '950013') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF LOT RELEASE';
                $scope.process = process;
            } else if (process == '950014') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'CERTIFICATE OF LOT RELEASE';
                $scope.process = process;
            }

        } else if (process == '950007' || process == '950008' || process == '950009' || process == '950010') {
            if (process == '950007') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'TRANSLATION MODERN REGISTRATION';
                $scope.process = process;
            } else if (process == '950008') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'TRANSLATION IMPORTING';
                $scope.process = process;
            } else if (process == '950009') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'TRANSLATION MANUFACTURING';
                $scope.process = process;
            } else if (process == '950010') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'TRANSLATION PLACE';
                $scope.process = process;
            }

        } else if (process == '950005' || process == '950015' || process == '950016') {
            if (process == '950005') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'การออกหนังสือรับรองมาตรฐานวิธีการที่ดีในการผลิต';
                $scope.process = process;
            } else if (process == '950015') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'การออกหนังสือรับรองมาตรฐานวิธีการที่ดีในการผลิต';
                $scope.process = process;
            } else if (process == '950016') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'การออกหนังสือรับรองมาตรฐานวิธีการที่ดีในการผลิต';
                $scope.process = process;
            }
        } else if (process == '950017' || process == '950018' || process == '950019') {
            if (process == '950017') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'คำขอหนังสือรับรองการนำหรือสั่งยาสำเร็จรูปสำหรับมนุษย์ (ช.ม.)';
                $scope.process = process;
            } else if (process == '950018') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'คำขอหนังสือรับรองการนำหรือสั่งยาสำเร็จรูปสำหรับสัตว์ (ช.ส.)';
                $scope.process = process;
            } else if (process == '950019') {
                $scope.SUBPATH = SET_URL_SV('/FRM_CERTIFICATE_CPP/FRM_MAIN_DRUG_CER');
                $scope.HEADER = 'คำขอหนังสือรับรองการนำหรือสั่งเภสัชเคมีภัณฑ์ (ช.ว.)';
                $scope.process = process;
            }
        }
    };

    $scope.BTN_INPUT = function (process) {
        if (process == '950002' || process == '950003' || process == '950004' || process == '950001') {
            REDIRECT('/FRM_CERTIFICATE_CPP/INPUT_CPP');
        } else if (process == '950007') {
            REDIRECT('/FRM_CERTIFICATE_TRANSLATION/INPUT_TRANSLATE_REGISTRATION');
        } else if (process == '950008' || process == '950009' || process == '950010') {
            REDIRECT('/FRM_CERTIFICATE_TRANSLATION/INPUT_LOCATION_ENG_20');
        } else if (process == '950102') {
            REDIRECT('/FRM_CERTIFICATE_LORPOR/INPUT_RORPOR_02');
        } else if (process == '950103') {
            REDIRECT('/FRM_CERTIFICATE_LORPOR/INPUT_RORPOR_03');
        } else if (process == '950104') {
            REDIRECT('/FRM_CERTIFICATE_LORPOR/INPUT_RORPOR_04');
        } else if (process == '950105') {
            REDIRECT('/FRM_CERTIFICATE_LORPOR/INPUT_RORPOR_05');
        } else if (process == '950005') {
            REDIRECT('/FRM_CERTIFICATE_GxP/INPUT_CERTIFICATE_GMP');
        } else if (process == '950015') {
            REDIRECT('/FRM_CERTIFICATE_GxP/INPUT_CERTIFICATE_GDP');
        } else if (process == '950016') {
            REDIRECT('/FRM_CERTIFICATE_GxP/INPUT_CERTIFICATE_GPP');
        } else if (process == '950202') {
            REDIRECT('/FRM_CERTIFICATE_ANOTHER/INPUT_CHOR_MOR');
        } else if (process == '950203') {
            REDIRECT('/FRM_CERTIFICATE_ANOTHER/INPUT_CHOR_SOR');
        } else if (process == '950201') {
            REDIRECT('/FRM_CERTIFICATE_ANOTHER/INPUT_CHOR_WOR');
        }
    };

    $scope.SELECT_DATA = function (datas) {
        REDIRECT('/FRM_CERTIFICATE_CPP/FRM_CARTIFICATE_CER_CONFIRM');
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/FRM_CERTIFICATE_CPP/FRM_CPP_MAIN');
    };

    $scope.BTN_SAVE_CPP = function () {
        Swal.fire({
            title: 'SUCCESS',
            text: 'บันทึกข้อมูลเรียบร้อย',
            icon: 'ดฟสหำ',
            confirmButtonColor: '#3085d6',
            cornfirmButtonText: 'OK'
        });
    };

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);

function Openmodel() {
    $('#myModal').modal('toggle'); // เป็นคำสั่งเปิดปิด
}

app.filter('startform', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});