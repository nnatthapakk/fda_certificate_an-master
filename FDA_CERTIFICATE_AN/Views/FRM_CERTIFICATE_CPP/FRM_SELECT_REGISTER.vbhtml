<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CPP/SELECT_REGISTER.js"></script>

<div ng-controller="SELECT_REGISTER" ng-app="ANGULAR_APP">
    <div style="font-family:'Taviraj'">
        <div class="in">
            <table class="table" width="100%" style="font-size:20px">
                <tr>
                    <td width="10%">ชื่อบริษัท</td>
                    <td width="50%">{{DATA[0].company_name}}</td>
                    <td>(เลขที่ใบอนุญาต : {{LCN_DATA.lcnno_no}} )</td>
                </tr>
            </table>
            <table class="table" width="100%" style="font-size:20px">
                <tr>
                    <td width="10%">ที่อยู่</td>
                    <td>{{DATA[0].fulladdr}}</td>
                </tr>
                <tr>
                    <td>สถานที่</td>
                    <td>{{DATA[0].thanm}}</td>
                </tr>
            </table>
        </div>
        <div class="in">
            <br />
            <div style="margin-left:5%"><h2><b>เลือกรายการ</b></h2></div>
            <div class="row">
                <div class="col-sm-12">
                    <div class="search-item">
                        <input class="form-control search-input" type="text" placeholder="ค้นหา เภสัชเคมีภัณฑ์....." ng-model="filter" />
                        <i class="fa fa-search search-icon"></i>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <div class="search-item">
                        <input class="form-control search-input" type="text" placeholder="ค้นหา...เลขทะเบียน หรือ ชื่อผลิตภัณฑ์" ng-model="filter">
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
                                    <th>เลขทะเบียน</th>
                                    <th>ชื่อผลิตภัณฑ์ (ไทย)</th>
                                    <th>ชื่อผลิตภัณฑ์ (อังกฤษ)</th>
                                    <th>วันที่อนุมัติ</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="datas in LIST_DATA | filter : filter">

                                    <td>{{datas.register}}</td>
                                    <td>{{datas.thadrgnm}}</td>
                                    <td>{{datas.engdrgnm}}</td>
                                    <td>{{datas.appdate}}</td>
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
</div>