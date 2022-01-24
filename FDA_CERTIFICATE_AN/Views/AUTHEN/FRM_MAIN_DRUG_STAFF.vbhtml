@Code
    ViewData("Title") = "FRM_MAIN_DRUG_STAFF"
    Layout = ""
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js"></script>

<div ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP">
    <div class="ic">
        <div><h3>แสดงรายการ Certificate ที่ผ่านการอนุมัติแล้ว</h3></div>
        <hr />
        <div class="row">
            <div class="col-sm-12">
                <div class="search-item">
                    <input class="search-input" type="text" placeholder="ค้นหา..." ng-model="filter">
                    <i class="fa fa-search search-icon"></i>
                </div>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>เลขรับ</th>
                                <th>วันที่รับ</th>
                                <th>ประเภท CER</th>
                                <th>Ref.No</th>
                                <th>รหัสดำเนินการ</th>
                                <th>สถานะ</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="datas in LIST_CER | filter : filter">

                                <td>{{datas.RCVNO}}</td>
                                <td>{{datas.datercvno}}</td>
                                <td>{{datas.PROCESS_DESCRIPTION}}</td>
                                <td>{{datas.REF_CODE}}</td>
                                <td>{{datas.XML_NAME}}</td>
                                <td>{{datas.STATUS_NAME}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_LCN(datas,'12')">
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
