



    <div>
        <div class="ic" style="font-family:'Taviraj'">
            <table width="100%">
                <tr>
                    <td width="70%"></td>
                    <td width="5%" style="text-align:right">เลขรับ</td>
                    <td width="25%"><input type="text" class="form-control" /></td>
                </tr>
                <tr>
                    <td width="70%"></td>
                    <td width="5%" style="text-align:right">วันที่</td>
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
                <h3>คำขอแจ้งข้อมูลเพิ่มเติม สำหรับการขนส่งคนละคราว</h3>
            </center>
            <br />
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="15%">ด้วย (นาย, นาง, นางสาว)</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
                <tr>
                    <td></td>
                    <td style="font-size:16px;text-align:center">(ผู้ดำเนินกิจการ)</td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="20%">ในนามของ (บริษัท / ห้าง / ร้าน)</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
                <tr>
                    <td></td>
                    <td style="font-size:16px;text-align:center">(ผู้รับอนุญาต)</td>
                </tr>
            </table>
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="20%">ตามใบอนุญาต (ผลิต/นำหรือสั่ง)</td>
                    <td width="15%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="5%">เลขที่</td>
                    <td width="10%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>มีความประสงค์แจ้งข้อมูลเพิ่มเติมสำหรับการขนส่งคนละคราว ของตำรับยารายละเอียดดังนี้</td>
                </tr>
            </table>
            <div style="font-size:16px" align="center">(๑ คำขอ ต่อ ๑ ทะเบียนตำรับยา ต่อ ๑ รุ่นการผลิต)</div>
            <table width="90%" align="center" style="font-size:20px">
                <tr>
                    <td width="20%">เลขที่หนังสือรับรองรุ่นการผลิต</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
            </table>
            <table width="90%" align="center" style="font-size:20px">
                <tr>
                    <td width="15%">เลขที่เบียนตำรับยาที่</td>
                    <td width="30%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td width="5%">ชื่อยา</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
            </table>
            <table width="90%" align="center" style="font-size:20px">
                <tr>
                    <td width="15%">เลขแสดงรุ่นการผลิตที่</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                </tr>
            </table>
            <table width="90%" align="center" style="font-size:20px">
                <tr>
                    <td width="20%">วันที่ผลิตยา</td>
                    <td width="30%">
                        <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header ">
                        </md-datepicker>
                    </td>
                    <td width="25%">วันที่ยาสิ้นอายุ</td>
                    <td>
                        <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header ">
                        </md-datepicker>
                    </td>
                </tr>
            </table>
            <br />
            <div style="font-size:20px">โดยการขนส่งครั้งนี้มีรายละเอียดดังนี้</div>
            <br />
            <table width="90%" align="center" style="font-size:20px">
                <tr>
                    <td width="15%">วันที่นำสั่งฯ เสร็จสิ้น</td>
                    <td></td>
                </tr>
            </table>
            <table width="90%" align="center" style="font-size:20px">
                <tr>
                    <td>รายละเอียดขนาดบรรจุที่ขนส่งครั้งนี้ (หากไม่พอโปรดจัดทำเป็นเอกสารแนบท้าย)</td>
                    <td></td>
                </tr>
            </table>
            <table width="90%" align="center" style="font-size:20px">
                <tr>
                    <td width="20%">รวมจำนวนที่นำหรือสั่ง ฯ ครั้งนี้</td>
                    <td width="20%"><input type="text" class="form-control" /></td>
                    <td>(โด๊ส / ยูนิต / มิลลิตร / ขวด / หลอด)</td>
                </tr>
            </table>
            <br />
            <div style="font-size:20px">โดยได้แนบเอกสาร/หลักฐานประกอบการพิจารณามาด้วยดังนี้</div>
            <div style="font-size:20px;margin-left:2em">
                <div><input type="checkbox" />&nbsp;&nbsp;หนังสือรับรองรุ่นการผลิตฉบับเดิม</div>
                <div><input type="checkbox" />&nbsp;&nbsp;เอกสารแสดงวิธีการและรายละเอียดการขนส่งครั้งนี้</div>
                <div><input type="checkbox" />&nbsp;&nbsp;เอกสารที่แสดงคุณภาพระหว่างการขนส่งครั้งที่ยื่นคำขอนี้</div>
                <div><input type="checkbox" />&nbsp;&nbsp;เอกสารอื่นๆ (ถ้ามีโปรดระบุเป้นเอกสารแนบท้าย)</div>
            </div>
            <br />
            <br />
            <table width="100%" style="font-size:20px">
                <tr>
                    <td width="65%"></td>
                    <td width="5%" style="text-align:right">ลงชื่อ</td>
                    <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>ผู้รับอนุญาต</td>
                </tr>
                <tr>
                    <td width="65%"></td>
                    <td width="5%" style="text-align:right">(</td>
                    <td width="20" style="border-bottom:dotted;border-bottom-width:thin"></td>
                    <td>) ตัวบรรจง</td>
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
