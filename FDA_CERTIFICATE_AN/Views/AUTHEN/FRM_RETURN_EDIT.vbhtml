@Code
    ViewData("Title") = "FRM_RETURN_EDIT"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/AUTHEN/FRM_CER_MAIN_CTRL.js"></script>

<div ng-controller="FRM_CER_MAIN_CTRL" ng-app="ANGULAR_APP">
    <div class="ic" style="font-family:'Taviraj'">
        <div class="row">
            <div class="col-sm-2 set-topic" style="font-size:20px">
                รายละเอียดการชี้แจ้ง:
            </div>
            <div class="col-sm-10">
                <textarea class="form-control" ng-model="" style="width:100%"></textarea>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-2 set-topic" style="font-size:20px">
                กำหนดส่งเอกสาร:
            </div>
            <div>
                <md-datepicker ng-model="" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header">
                </md-datepicker>
            </div>
        </div>
        <br />
        <div class="row" style="padding-top: 30px;">
            <div class="col-sm-6">
                <h1>
                    รายการเอกสารชี้แจง
                </h1>
            </div>
            <div class="col-sm-6" style="text-align:right;margin-bottom:20px;">
                <input type="button" class="btn btn-lg" style="background-color:#71C970;color:white" ng-click="ADD_FILE_LIST()" value="เพิ่มเอกสารแนบ" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12" style="width:100%">
                <div class="card" @*ng-repeat="datas in DOC_LIST.FILE_LISTs"*@>
                    <div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                        หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                    </div>
                    <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                        หัวข้อเอกสาร (ไม่บังคับแนบ)
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-7">
                                <input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" style="width:100%" ngf-select="selectFileforUpload(datas,$files)" />
                            </div>
                            <div class="col-sm-2">
                                <a ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">{{datas.FLAG}}</a>
                            </div>
                            <div class="col-sm-2" align="right">
                                <input type="button" ng-click="UPLOAD_PDF_STAFF(datas)" value="บันทึก" />
                            </div>
                            <div class="col-sm-1">
                                <input type="button" ng-click="deleteRow(datas,$index)" value="ลบ" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-12" style="text-align:center;margin-bottom:20px;">
            <input type="button" class="btn btn-lg" style="width:10%;background-color:#71C970;color:white" ng-click="" value="บันทึก" />
            <input type="button" class="btn btn-lg" style="width:10%;background-color:#F9D759" ng-click="BTN_BACK_CONFIRM()" value="ย้อนกลับ" />
        </div>
    </div>
</div>