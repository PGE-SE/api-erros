<template>
    <div class="border m-5 shadow-sm rounded">
      <div class="custom-file mt-5 w-50 shadow-sm bg-body rounded">
        <input type="file" class="custom-file-input" id="customFileLang">
        <label class="custom-file-label color-gray" for="customFile">Insira a imagem</label>
        <input type="text" class="form-control my-2 text-center " id="inlineFormInput" placeholder="Mensagem">
      </div>
      <div class="form-group mt-3">
        <button class="btn btn-primary cb" type="button" id="inputGroupFileAddon04">Upload</button>
      </div>
    </div>
</template>

<script>
export default {
  name: 'Home',
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
template {
  align-content: center;
}
</style>
