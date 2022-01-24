<script type="text/javascript"></script>

<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CPP/CPP_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div ng-controller="CPP_CTRL" ng-app="ANGULAR_APP">
    <div class="ic" style="font-family:'Taviraj'">
        <h1 style="text-align:center">คำขอหนังสือรับรองผลิตภัณฑ์ยา</h1>
        <p class="line-header"></p>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="75%"></td>
                <td width="5%" style="text-align:right">วันที่</td>
                <td>
                    <md-datepicker ng-model="" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header">
                    </md-datepicker>
                </td>
            </tr>
            <tr>
                <td width="75%"></td>
                <td width="5%" style="text-align:right">เขียนที่</td>
                <td><input type="text" class="form-control" /></td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="10%" style="text-align:right" class="auto-style53">ข้าพเจ้า</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="10%">ผู้รับอนุญาต</td>
                <td width="25%"><input type="radio" id="ผลิตยา" name="md" value="1" />&nbsp;&nbsp;ผลิตยา/แบ่งบรรจุยา(manufacturer)</td>
                <td width="20%"><input type="radio" id="นำหรือสั่งยา" name="md" value="2" />&nbsp;&nbsp;นำหรือสั่งยา(import)</td>
                <td width="7%">ใบอนุญาตที่</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="32%">ชื่อสถานที่ผลิต/แบ่งบรรจุ/นำเข้า Product license holder</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="14%">ตั้งอยู่เลขที่ : Located at</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="40%">ชื่อสถานที่ผลิตในต่างประเทศ(กรณีนำสั่งฯ/แบ่งบรรจุ): Manufactured by</td>
                <td><input type="text" class="form-control inline" style="width:100%" /></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="7%">Located at</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td style="text-align:center">ขอให้สำนักยา สำนักงานคณะกรรมการอาหารและยาออกหนังสือรับรองผลิตภัณฑ์</td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="23%">ประเภท (เลือกเพียง 1 ประเภท)</td>
                <td width="7%"><input type="checkbox" ng-disabled="true" />&nbsp;&nbsp;CFS</td>
                <td width="10%"><input type="checkbox" />&nbsp;&nbsp;CPP (แนวตั้ง)</td>
                <td width="20%"><input type="checkbox" />&nbsp;&nbsp;CPP (WHO แบบขวาง 1 หน้า)</td>
                <td width="15%"><input type="checkbox" />&nbsp;&nbsp;CPP (WHO 5 หน้า)</td>
                <td width="4%">จำนวน</td>
                <td width="20%"><input type="text" class="form-control inline" /></td>
                <td>ฉบับ</td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="13%">ชื่อยา : Product name</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td><input type="checkbox" />&nbsp;&nbsp;เพิ่มชื่อเพื่อการส่งออก(แนบหลักฐานการได้รับอนุญาตประกอบด้วย)</td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="37%">เลือก/เพิ่มชื่อยาเพื่อการส่งออก : Name for export (it applicable)</td>
                <td>
                    <select class="form-control selectpicker" data-live-search="true" title="--Please select--">
                        <option>1</option>
                    </select>
                </td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="2%"></td>
                <td width="47%">ประเทศที่นำเข้าผลิตภัณฑ์ (กรณีต้องการระบุในหนังสือรับรองฯ) : Importing Country</td>
                <td>
                    <select class="form-control selectpicker" data-live-search="true" title="--Please select--">
                        <option>1</option>
                    </select>
                </td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="15%">รูปแบบยา : dosage form</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="20%">เลขทะเบียนที่ : Registered no.</td>
                <td width="30%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="20%">วันที่ออกเลขทะเบียน : Date of issue</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="45%">ตำรับยา : Formula Active Ingredient (s) and amount (s) per unit dose</td>
                <td width="4%">Each</td>
                <td width="20%"><input type="text" class="form-control inline" /></td>
                <td>&nbsp;contains</td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td>หมายเหตุ :</td>
                <td>กรอกเป็นภาษาอังกฤษ กรณียาแผนโบราณ ให้แจ้งชื่อวิทยาศาสตร์ในสูตร ส่วนประกอบสำคัญ ข้าพเจ้าได้แนบหลักฐานมาด้วยคือ</td>
            </tr>
            <tr>
                <td></td>
                <td>(1) สำเนาใบสำคัญการขึ้นทะเบียนตำรับยาหรือใบแทน</td>
            </tr>
            <tr>
                <td></td>
                <td>(2) สำเนาหนังสือรับรอง GMP</td>
            </tr>
            <tr>
                <td></td>
                <td>(3) เอกสารที่เป็นหลักฐานเกี่ยวข้อง เช่น สำเนาแบบ ท.ย.1 หน้า 1 และ 2 แบบ แก้ไขเปลี่ยนแปลงที่ได้ รับอนุญาตในรายการที่เกี่ยวข้อง (เช่น แก้ไขชื่อยา สูตร เป็นต้น)</td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px;border-color:#E5E2D8" border="1">
            <tr>
                <td width="50%" align="center">
                    <form name="myForm">
                        <label>
                            <input type="radio" value="1" />
                            หนังสือรับรองรูปแบบทั่วไป
                        </label>
                        <label>&nbsp;&nbsp;&nbsp;</label>
                        <label>
                            <input type="radio" value="2" />
                            หนังสือรับรองที่มีเอกสารนอกเหนือจากสูตร (เช่น ฉลาก เอกสารกำกับยา เป็นต้น)
                        </label>
                    </form>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="35%"></td>
                <td width="30%"></td>
                <td width="5%" style="text-align:right">ลงชื่อ</td>
                <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="10%">ผู้ยื่นคำขอ</td>
            </tr>
            <tr>
                <td width="35%"></td>
                <td width="30%"></td>
                <td width="5%" style="text-align:right">ลงชื่อ</td>
                <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="10%">ผู้บันทึกคำขอ</td>
            </tr>
        </table>
        <br />
    </div>
    <div class="in">
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
                                    <input type="button"  ng-click="deleteRow(datas,$index)" value="ลบ (Delete)" />
                                </td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
        <br />
        <br />
        <div class="col-sm-12" style="text-align:center;margin-bottom:40px;">
            <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="BTN_SAVE_CPP()" value="บันทึก" />
            <input type="button" class="btn btn-lg" style="background-color:#FFD700" ng-click="BTN_BACK()" value="ย้อนกลับ" />
        </div>
    </div>
</div>
