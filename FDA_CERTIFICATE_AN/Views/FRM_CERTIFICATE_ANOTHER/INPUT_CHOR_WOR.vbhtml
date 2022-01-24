@Code
    ViewData("Title") = "INPUT_CHOR_WOR"
End Code


<div>
    <div class="ic" style="font-family:'Taviraj'">
        <div>
            <p style="text-align: right; font-size: 16px;">แบบ ช.ว.</p>
        </div>
        <div>
            <table style="width: 200px;" border="1" align="right">
                <tr>
                    <td style="text-align: left">
                        เลขรับที่<br />
                        วันที่<br />
                        ลงชื่อ<span style="padding-left: 100px;">ผู้รับขอ</span>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <br />
        <br />
        <center>
            <h4>คำขอหนังสือรับรองการนำหรือสั่งเภสัชเคมีภัณฑ์เข้ามาในราชอาณาจักร</h4>
            <h4>ตามประกาศกระทรวงพาณิชย์ซึ่งออกตามพระราชบัญญัติการส่งออกไปนอก</h4>
            <h4>และการนำเข้ามาในราชอาณาจักรซึ่งสินค้า พ.ศ. ๒๕๒๒</h4>
        </center>
        <hr style="width:30%;border-color:black;border-style:dotted" />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="70%"></td>
                <td width="5%" style="text-align:right">เขียนที่</td>
                <td><input type="text" class="form-control" /></td>
            </tr>
            <tr>
                <td></td>
                <td style="text-align:right">วันที่</td>
                <td>
                    <md-datepicker ng-model="" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header">
                    </md-datepicker>
                </td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="7%">๑. ข้าพเจ้า</td>
                <td width="85%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>ผู้ยื่นคำขอ</td>
            </tr>
        </table>
        <div style="font-size:16px;text-align:center">(ชื่อผู้รับอนุญาตนำหรือสั่งยาเข้ามาในราชอาณาจักร)</div>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="20%">เลขที่ใบอนุญาตนำหรือสั่งยา</td>
                <td width="10%"><input type="checkbox" />&nbsp;&nbsp;แผนปัจจุบัน</td>
                <td><input type="checkbox" />&nbsp;&nbsp;แผนโบราณเข้ามาในราชอาณาจักร</td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="10%">ตั้งอยู่เลขที่</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="5%">โทรศัพท์</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="15%">มีผู้ดำเนินกิจการชื่อ</td>
                <td width="40%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="5%">อายุ</td>
                <td width="10%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="5%" style="text-align:left">ปี</td>
                <td width="5%">สัญชาติ</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="5%">อยู่เลขที่</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="5%">โทรศัพท์</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <br />
        <div style="font-size:20px">๒. ข้าพเจ้ามีความประสงค์จะขอหนังสือรับรองการนำหรือสารหลั่ง</div>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="5%">ชื่อผู้ผลิต</td>
                <td width="40%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td width="10%">ประเทศที่ผลิต</td>
                <td>
                    <select class="form-control selectpicker" data-live-search="true" title="--Please select--">
                    </select>
                </td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="5%">จำนวน</td>
                <td width="20%"><input type="text" class="form-control" /></td>
                <td width="5%">กิโลกรัม</td>
                <td>เข้ามาในราชอาณาจักร โดยเข้าสู่ประเทศไทยทางด่านอาหารและยา ดังนี้</td>
            </tr>
        </table>
        <br />
        <table width="80%" align="center" style="font-size:20px">
            <tr>
                <td width="50%"><input type="checkbox" />&nbsp;&nbsp;ท่าเรือกรุงเทพ (คลองเตย)</td>
                <td><input type="checkbox" />&nbsp;&nbsp;ท่าอากาศยานดอนเมือง</td>
            </tr>
            <tr>
                <td width="50%"><input type="checkbox" />&nbsp;&nbsp;ท่าเรือแหลมฉบัง</td>
                <td><input type="checkbox" />&nbsp;&nbsp;ท่าเรือเอกชน ปท. ๑๐</td>
            </tr>
            <tr>
                <td width="50%"><input type="checkbox" />&nbsp;&nbsp;รพท.การรถไฟแห่งประเทศไทย (ลาดกระบัง)</td>
                <td><input type="checkbox" />&nbsp;&nbsp;ท่าอากาศยานสุวรรณภูมิ (คลังสินค้า)</td>
            </tr>
            <tr>
                <td width="50%"><input type="checkbox" />&nbsp;&nbsp;ไปรษณีย์กรุงเทพฯ</td>
                <td><input type="checkbox" />&nbsp;&nbsp;พระสมุทรเจดีย์</td>
            </tr>
            <tr>
                <td width="50%"><input type="checkbox" />&nbsp;&nbsp;สมุทรปราการ</td>
                <td><input type="checkbox" />&nbsp;&nbsp;ท่าเรือเอกชน บริษัท แอคทู-ลั่ม จำกัด</td>
            </tr>
            <tr>
                <td width="50%"><input type="checkbox" />&nbsp;&nbsp;ท่าเรือเอกชน บริษัท สยามแก๊สแอนด์ ปิโตรเคมีคัลส์ จำกัด (มหาชน)</td>
                <td><input type="checkbox" />&nbsp;&nbsp;ท่าเรือเอกชน บริษัท ทีเอสขนส่งและโลจิสติกส์ จำกัด</td>
            </tr>
            <tr>
                <td width="50%"><input type="checkbox" />&nbsp;&nbsp;ท่าเรือเอกชน บริษัท บางกอก บาร์จ เทอร์มินอล จำกัด</td>
                <td></td>
            </tr>
        </table>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="15%">สถานที่เก็บสารตั้งอยู่เลขที่</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <br />
        <div style="font-size:20px">๓. ข้าพเจ้าได้ส่งหลักฐานมาด้วย คือ</div>
        <div style="font-size:20px;margin-left:5em"><input type="checkbox" />&nbsp;&nbsp;๓.๑ สำเนาใบอนุญาตนำหรือสั่งยาเข้ามาในราชอาณาจักร</div>
        <div style="font-size:20px;margin-left:5em"><input type="checkbox" />&nbsp;&nbsp;๓.๒ โครงการวิจัย</div>
        <div style="font-size:20px;margin-left:5em"><input type="checkbox" />&nbsp;&nbsp;๓.๓ วิธีวิเคราะห์</div>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="60%"></td>
                <td width="10%" style="text-align:right">(ลายมือชื่อ)</td>
                <td width="20%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>ผู้ยื่นขอ</td>
            </tr>
            <tr>
                <td></td>
                <td style="text-align:right">(</td>
                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>)</td>
            </tr>
        </table>
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg" style="background-color:#71C970;color:white">บันทึก</button>
            <button class="btn btn-lg" style="background-color:#F9D759">ย้อนกลับ</button>
        </div>
    </div>
</div>

