@Code
    ViewData("Title") = "FRM_MAIN_RORPOR_CER"
    Layout = ""
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CPP/FRM_SELECT_REGISTER.js"></script>

<div ng-controller="FRM_SELECT_REGISTER" ng-app="ANGULAR_APP">
    <div class="ic" style="font-family:'Taviraj'">
        <br />
        <div class="row">
            <table class="table">
                <tr>
                    <td width="70%"><h3>CERTIFICATE OF LOT RELEASE</h3></td>
                    <td align="center">
                        <input type="button" class="btn btn-lg" style="width:50%;background-color:#38A86B;color:white" ng-click="BTN_INPUT" value="สร้างคำขอ" />
                    </td>
                </tr>
            </table>
            <table class="table" style="width:90%;margin-left:5%">
                <tr>
                    <td width="20%"><b>ชื่อยา :</b></td>
                    <td>
                        PARA
                    </td>
                </tr>
                <tr>
                    <td><b>เลขทะเบียน :</b></td>
                    <td>
                        1A 1/62 (NG)
                    </td>
                </tr>
                <tr>
                    <td><b>ชื่อผู้รับอนุญาต :</b></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td><b>ที่อยู่ :</b></td>
                    <td>
                        <b></b>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <hr />
        <div class="row">
            <div class="col-sm-12" style="text-align:left">
                <div class="search-item">
                    <input class="search-input" type="text" placeholder="ค้นหา..." ng-model="filter">
                    <i class="fa fa-search search-icon"></i>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style="border-top: 10px solid #F9D027;width:90%;margin-left:5%">
                    <table style="font-family: 'Taviraj'" class="table" id="myTable">
                        <thead>
                            <tr>
                                <th>เลขที่รับ</th>
                                <th>วันที่ยื่นเรื่อง</th>
                                <th>ประเภท Certificate</th>
                                <th>รูปแบบ</th>
                                <th>สถานะ</th>
                                <th>เลขอ้างอิง</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            @*<tr>
                                    <td>K 1/62 (NC)</td>
                                    <td>พารา</td>
                                    <td>Para</td>
                                    <td></td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="">
                                            เลือก
                                        </a>
                                    </td>
                                </tr>*@
                            <tr @*ng-repeat="datas in LIST_DATA | filter : filter"*@>

                                <td>{{datas.register}}</td>
                                <td>{{datas.thadrgnm}}</td>
                                <td>{{datas.engdrgnm}}</td>
                                <td>{{datas.appdate}}</td>
                                <td></td>
                                <td></td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_DATA(datas,'12')">
                                        เลือก
                                    </a>
                                </td>
                            </tr>
                        </tbody>
                        <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                        ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                        boundary-link-numbers="true" rotate="false" max-size="maxSize">
                        </uib-pagination>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
