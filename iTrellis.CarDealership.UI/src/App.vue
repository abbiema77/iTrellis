<template>
  <div id="app" class="container-fluid">
    <top-bar></top-bar>
    <router-view />
        <foot></foot>
  </div>
</template>
<script>
import TopBar from "./components/TopBar";
import Foot from "./components/Footer";
export default {
  components: {
    TopBar,
    Foot
  }
};
</script>
<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
