


<div>
    <div class="ic" style="font-family:'Taviraj'">
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="70%"></td>
                <td width="5%">เลขรับ</td>
                <td width="25%"><input type="text" class="form-control" /></td>
            </tr>
            <tr>
                <td width="70%"></td>
                <td width="5%">วันที่</td>
                <td width="25%">
                    <md-datepicker ng-model="" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header">
                    </md-datepicker>
                </td>
            </tr>
        </table>
        <br />
        <center>
            <h3>คำขอหนังสือรับรองรุ่นการผลิตยาชีววัตถุ</h3>
            <h3>กรณีที่มีความจำเป็นเร่งด่วนเพื่อประโยชน์สาธารณะ</h3>
        </center>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="14%">ด้วย (นาย, นาง, นางสาว)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="20%">ในนามของ (กระทรวง / ทบวง / กรม)</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
            <tr>
                <td></td>
                <td style="font-size:16px;text-align:center">(กระทรวง / ทบวง / กรม / องค์การเภสัชกรรม / สภากาชาดไทย)</td>
            </tr>
        </table>
        <br />
        <div style="font-size:20px">
            ได้ดำเนินการผลิตและนำสั่งยาแผนปัจจุบันโดยอาศัยความตามที่กำหนดไว้ในมาตรา ๑๓ แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐ และฉบับที่ได้แก้ไขเพิ่มเติมและ
            มีความประสงค์ขอหนังสือรับรองรุ่นการผลิตยาชีววัตถุ ซึ่งออกตามความที่กำหนดในกระทรวงว่าด้วยการรับรองรุ่นการผลิตยาแผนปัจจุบันที่เป็นยาชีววัตถุ พ.ศ. ๒๕๕๓ โดยมีรายละเอียดดังนี้
        </div>
        <div style="font-size:16px" align="center">(๑ คำขอ ต่อ ๑ ทะเบียนตำรับยา ต่อ ๑ รุ่นการผลิต)</div>
        <br />
        <table width="90%" align="center" style="font-size:20px">
            <tr>
                <td width="4%">ชื่อยา</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <div style="font-size:16px" align="center">รายละเอียดตำรับยา (ปริมาณและความแรงของตัวยาสำคัญและตัวยาที่ไม่สำคัญ หากไม่พอโปรดจัดทำเป็นเอกสารแทบท้าย)</div>
        <table width="90%" align="center" style="font-size:20px">
            <tr>
                <td width="20%">เลขแสดงรุ่นการผลิตที่บนขวดยา</td>
                <td><input type="text" class="form-control" /></td>
            </tr>
        </table>
        <table width="90%" align="center" style="font-size:20px">
            <tr>
                <td width="30%">เลขแสดงรุ่นการผลิตที่บนขวดน้ำยาละลาย (ถ้ามี)</td>
                <td><input type="text" class="form-control" /></td>
            </tr>
        </table>
        <table width="90%" align="center" style="font-size:20px">
            <tr>
                <td width="20%">แสดงเลขรุ่นการผลิตที่บนกล่องยา</td>
                <td><input type="text" class="form-control" style="background-color:#D2FBEA " /></td>
            </tr>
        </table>
        <table width="90%" align="center" style="font-size:20px">
            <tr>
                <td width="20%">วันที่ผลิต</td>
                <td>
                    <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
                <td width="20%">วันที่ยาสิ้นอายุ</td>
                <td>
                    <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
            </tr>
            <tr>
                <td>วันที่ผลิตน้ำยาทำละลาย (ถ้ามี)</td>
                <td>
                    <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
                <td>วันที่น้ำยาทำละลาย สิ้นอายุ (ถ้ามี)</td>
                <td>
                    <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
            </tr>
        </table>
        <table width="90%" align="center" style="font-size:20px">
            <tr>
                <td>รายละเอียดขนาดบรรจุ (หากไม่พอโปรดจัดทำเป็นเอกสารแนบท้าย)</td>
                <td></td>
            </tr>
        </table>
        <table width="90%" align="center" style="font-size:20px">
            <tr>
                <td width="30%">รวมจำนวนที่ผลิตในประเทศ / นำหรือสั่งฯ ทั้งสิ้น</td>
                <td width="20%"><input type="text" class="form-control" /></td>
                <td>(โด๊ส / ยูนิต / มิลิลิตร / ขวด / หลอด)</td>
            </tr>
        </table>
        <br />
        <div style="font-size:20px">
            ทั้งนี้หน่วยงานขอรับรองว่าหน่วยงานผู้ยื่นคำขอและตำรับยาที่ยื่นคำขอครั้งนี้มีคุณสมบัติเป็นไปตามหลักเกณฑ์ที่กำหนดและใช้เฉพาะ
            เพื่อประโชน์และความมั่นคงต่อระบบสาธารณสุขหรือเศรษฐกิจของประเทศ หรือเพื่อให้สามารถตอบสนองต่อสภาวะฉุกเฉินของ
            ประเทศได้อย่างทันท่วงทีหรือเพื่อใช้ในหน้าที่ควบคุม ป้อมกัน หรือบำบัดโรค ตามภารกิจของหน่วยงานอีกทั้งขอรับรองว่าหน่วยงานมี
            มาตรการเพียงพอในการติดตามความปลอดภัยจากการใช้ยา และมั่นใจว่าตำรับยารุ่นการผลิตที่ยื่นคำขอนี้มีการดำเนินการผลิตและ
            ประกันคุณภาพตามหลักวิชาการซึ่งเป็นที่ยอมรับ ณ ขณะเวลาที่ยื่นคำขอโดยได้แนบเอกสาร/หลักฐานประกอบการพิจารณามาด้วย
            ดังนี้
        </div>
        <br />
        <div style="font-size:20px;margin-left:5%"><input type="checkbox" />&nbsp;&nbsp;หนังสือรับรองรุ่นการผลิตที่ออกโดยผู้ผลิต</div>
        <div style="font-size:20px;margin-left:5%"><input type="checkbox" />&nbsp;&nbsp;สำเนาหนังสือมอบหมาย / แต่งตั้งให้ปฏิบัติราชการแทน / แต่งตั้งให้รักษาราชการแทน / หรือทำการแทน(เฉพาะกรณีเป็นการมอบอำนาจ)</div>
        <div style="font-size:20px;margin-left:5%"><input type="checkbox" />&nbsp;&nbsp;หนังสือชี้แจงและแจ้งเหตุกรณีที่มีความจำเป็นเร่งด่วนเพื่อประโยชน์สาธารณะ</div>
        <div style="font-size:20px;margin-left:5%"><input type="checkbox" />&nbsp;&nbsp;เอกสารสรุปกระบวบการผลิตของรุ่นการผลิตที่ยื่นคำขอ</div>
        <div style="font-size:20px;margin-left:5%"><input type="checkbox" />&nbsp;&nbsp;เอกสารอื่นๆ (ถ้ามี โปรดระบุเป็นเอกสารแนบท้าย)</div>
        <br />
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="65%"></td>
                <td width="5%" style="text-align:right">ลงชื่อ</td>
                <td width="25%" style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
            <tr>
                <td width="65%"></td>
                <td width="5%" style="text-align:right">ตำแหน่ง</td>
                <td width="25%" style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
            <tr>
                <td width="65%"></td>
                <td width="5%" style="text-align:right">วันที่</td>
                <td width="25%" style="border-bottom:dotted;border-bottom-width:thin"></td>
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

