﻿<!DOCTYPE html>
<html>
<head>
    <title></title>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name='created_by' content='This is example, please fill you name.'>


    <!-- Core template -->
    <link rel="stylesheet" type="text/css" href="~/css/fonts.css" />
    <link rel="stylesheet" type="text/css" href="~/css/icomoon/styles.css" />
    <link rel="stylesheet" type="text/css" href="~/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/bootstrap_limitless.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/layout.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/components.min.css" />

    <link rel="stylesheet" type="text/css" href="~/css/colors.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/fontawesome-all.min.css" />
    <link rel="stylesheet" type="text/css" href="~/css/home.css" />
    <link href="~/css/addition_css_20200408.css" rel="stylesheet" />
    <script type="text/javascript">var base_url = "./"; base_url_lang = "./en/"; var lang = "en";</script>
    @*<script type="text/javascript" src="/js/jquery-3.3.1.min.js"></script>*@
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/angular_material/1.1.12/angular-material.min.css">
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.25/datatables.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.25/datatables.min.js"></script>
    <link href="https://fonts.googleapis.com/css2?family=Taviraj:ital,wght@0,200;0,300;1,300&display=swap" rel="stylesheet">
    @*<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>*@
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.6.3/css/bootstrap-select.css" rel="stylesheet" />
    @*<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">*@


    @*<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" ></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" ></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" ></script>*@
    @*<script src="~/Scripts/datatables.min.js"></script>*@
    @*<link rel="stylesheet" type="text/css" href="DataTables/datatables.min.css" />

        <script type="text/javascript" src="DataTables/datatables.min.js"></script>*@
    <!-- CSS page -->
    <link rel="stylesheet" type="text/css" href="~/css/page.css" />
    <!-- End CSS page -->
    <!-- JS page -->
    <script type="text/javascript" src="~/js/common.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@8"></script>
    <script src="~/Scripts/angular.js"></script>
    <script src="~/Scripts/angular-animate.js"></script>
    <script src="~/Scripts/angular-aria.js"></script>
    <script src="~/Scripts/angular-messages.js"></script>
    <script src="~/Scripts/ng-file-upload.js"></script>
    <script src="~/Scripts/angular-material.js"></script>
    <link href="~/css/spinners.css" rel="stylesheet" />
    <script src="~/Scripts_angular/JS_COMMON.js"></script>
    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.10.2/moment.min.js"></script>
    @*<script src="//code.jquery.com/jquery-1.11.0.min.js"></script>*@


    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-select@1.13.14/dist/css/bootstrap-select.min.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap-select@1.13.14/dist/js/bootstrap-select.min.js"></script>




</head>
<body>
    @Html.Partial("header", Nothing)
    <div id="main-content" ng-app="ANGULAR_APP">

        <div class="loading-spiner-holder" data-loading style="background:#04adfd40;width: 100%;height: 100%;position: fixed;z-index: 99999;">
            <div class="loading-spiner">


                <span class="dots-loader" style="position: fixed;z-index: 100000;top: 50%;left: 50%;">Loading&#8230;</span>


            </div>
        </div>

        <div class="wrap-main-content">
            <div id="page">
                <div class="content-overlay"></div>
                @Html.Partial("menu_popup", Nothing)
                <div id="page-adr-2019">
                    <div class="page-header">
                        <div class="card-tab-control page-header-content header-elements-md-inline container">
                            @*<div class="tab-content">
                                    <div data-index="1" class="tab-content-item active"><i class="h-icon fas fa-bookmark"></i>DATA</div>
                                </div>*@
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="page-content container ">
                        <div class="content-wrapper">
                            <div class="content">
                                <div class="no-pm no-bg card no-border card-tab card-tab1 active">
                                    @RenderBody()
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <footer>
        <div class="ft1">
            สำนักงานคณะกรรมการอาหารและยา กระทรวงสาธารณสุข
        </div>
        <div class="ft2">
            88/24 ถนนติวานนท์ อ.เมือง จ.นนทบุรี 11000 <br>
            โทรศัพท์ 0-2590-7000
        </div>
    </footer>
</body>
</html>


