@Code
    ViewData("Title") = "FRM_CHOOSE_WORK_GROUP_LOT_RELEASE"
End Code

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div>
    <div class="ic" style="font-family:'Taviraj'">
        <h1 style="padding-left:1em"><b>ส่งกลุ่มงานพิจารณา</b></h1>
        <br />
        <table width="100%">
            <tr>
                <td width="15%"></td>
                <td width="70%">
                    <select class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                        <option></option>
                        <option>กลุ่มงานยาชีวะ</option>
                        <option>กลุ่มงาน OSSC</option>
                    </select>
                </td>
                <td></td>
            </tr>
        </table>
        <br />
    </div>
</div>