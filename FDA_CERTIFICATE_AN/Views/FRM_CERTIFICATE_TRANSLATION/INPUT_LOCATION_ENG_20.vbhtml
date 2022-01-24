@Code
    ViewData("Title") = "INPUT_LOCATION_ENG_20"
End Code

<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CPP/CPP_CTRL.js"></script>

<div ng-controller="CPP_CTRL" ng-app="ANGULAR_APP">
    <div class="ic" style="font-family:'Taviraj'">
        <center>
            <h2>คำขอหนังสือรับรองสถานที่เกี่ยวกับยา ฉบับภาษาอังกฤษ</h2>
        </center>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td style="text-align:right;width:80%">
                    เขียนที่
                </td>
                <td><input type="text" class="form-control" /></td>
            </tr>
            <tr>
                <td style="text-align:right;width:70px">
                    วันที่
                </td>
                <td>
                    <md-datepicker ng-model="" md-placceholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header">
                    </md-datepicker>
                </td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="10%"></td>
                <td width="15%">ข้าพเจ้า (นาย นาง นางสาว)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="10%">ผู้รับอนุญาต</td>
                <td width="7%"><input type="checkbox" />&nbsp;&nbsp;ผลิต</td>
                <td width="7%"><input type="checkbox" />&nbsp;&nbsp;นำสั่ง</td>
                <td width="7%"><input type="checkbox" />&nbsp;&nbsp;ขาย</td>
                <td width="10%"><input type="checkbox" />&nbsp;&nbsp;แผนปัจจุบัน</td>
                <td width="7%">ใบอนุญาตที่</td>
                <td><input type="text" class="form-control" /></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td><input type="checkbox" />&nbsp;&nbsp;แผนโบราณ</td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="14%">ตั้งอยู่เลขที่ Located at</td>
                <td><input type="text" class="form-control" /></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="5%"></td>
                <td width="68%">ขอให้ สำนักยา สำนักงานคณะกรรมการอาหารและยา ออกหนังสือรับรองสถานที่ออกหนังสือเกี่ยวกับยาฉบับภาษาอังกฤษ จำนวน</td>
                <td width="20%"><input type="text" class="form-control" /></td>
                <td>ฉบับ</td>
            </tr>
        </table>
        <br />
        <div style="font-size:20px">หมายเหตุ&nbsp;&nbsp;<font style="color:red">* กรอกเป็นภาษาอังกฤษ</font></div>
        <div style="font-size:20px;margin-left:5.5em">ข้าพเจ้าแนบหลักฐานมาด้วยคือ</div>
        <div style="font-size:20px;margin-left:5.5em">1. สำเนาใบอนุญาตที่ต่ออายุฉบับล่าสุด</div>
        <div style="font-size:20px;margin-left:5.5em">2. เอกสารที่เป็นหลักฐานเกี่ยวข้อง (สำเนาหนังสือรับรอง GMP, สำเนาหนังสือรับรองฉบับภาษาอังกฤษฉบับเดิม) ถ้ามี</div>
        <br />
        <br />
        <br />
        <br />
        <table width="50%" style="font-size:20px;float:right">
            <tr>
                <td width="10%">ลงชื่อ</td>
                <td width="50%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>ผู้ยื่นคำขอ</td>
            </tr>
        </table>
        <br />
        <br />
    </div>
    <div class="in" style="font-family:'Taviraj'">
        <div class="row" style="padding-top: 30px;">
            <div class="col-sm-6">
                <h2>
                    รายการเอกสารไฟล์แนบ (Attachments)
                </h2>
            </div>
            <div class="col-sm-6" style="text-align:right;margin-bottom:20px;">
                <input type="button" class="btn btn-lg btn-success" ng-click="ADD_FILE_LIST()" value="เพิ่มเอกสารแนบ (Attach files)" />
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

                        <table class="table" style="width:100%">
                            <tr>
                                <td colspan="5">
                                    {{datas.DES}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%;"><input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                                <td style="width:15%;">ชื่อไฟล์ (File Name)</td>
                                <td style="width:50%;">{{datas.FILENAME}}</td>
                                <td style="width:5%">
                                    <a ng-click="OPEN_DOC_PATH(datas.PATH)">{{FLAG}}</a>
                                </td>
                                <td style="width:20%; text-align: right;">
                                    @*<input type="button" ng-click="UPLOAD_PDFs(datas)" value="บันทึก" />*@
                                    <input type="button" ng-click="deleteRow(datas,$index)" value="ลบ (Delete)" />
                                </td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg" style="background-color:#71C970;color:white">บันทึก</button>
            <button class="btn btn-lg" style="background-color:#F9D759">ย้อนกลับ</button>
        </div>
    </div>
</div>
