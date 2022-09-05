export default function CheckBox(valueCheck) {
  var check =
    '<input type="checkbox"class="btn-check borderSite" id="'+valueCheck+'" autocomplete="off"><label class="btn borderSite " for="'+valueCheck+'">"'+valueCheck+'"</label>';

  return check;
}
