<template>
  <div class="home">
    <b-jumbotron class="jumbotron" header="iTrellis" lead="The best car dealership in town">
      <div class="bg"></div>
      <p>Click here and start finding your dream car</p>
      <b-button variant="primary" href="#">Search Car</b-button>
    </b-jumbotron>
    <div class="row d-flex justify-content-around">
      <div class="col-md-3 tile">1</div>
      <div class="col-md-3 tile">2</div>
      <div class="col-md-3 tile">3</div>
    </div>

  </div>
</template>

<script>
export default {
  data() {
    return {
      testAxios: null
    };
  },
  name: "Home",
  props: {
    msg: String
  },
  computed: {},
  methods: {
    async load() {}
  },
  mounted() {
    this.load();
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
$color_purple: #a0a951;
.jumbotron {
  position: relative;
  background: none;
  .bg {
    background-image: url("../img/old-car.jpg");
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-position: 50% 70%;
    background-size: cover;
    background-repeat: no-repeat;
    -webkit-filter: blur(3px);
    -moz-filter: blur(3px);
    -o-filter: blur(3px);
    -ms-filter: blur(3px);
    filter: blur(3px);
    z-index: -1;
  }

  h1 {
    color: white;
  }

  p {
    color: black;
  }
  .lead {
    font-size: 200%;
  }
}
.tile{
  width: 50%;
	display: inline-block;
	box-sizing: border-box;
	background: #fff;		
	padding: 20px;
	margin-bottom: 10px;
  background: $color_purple;
color:white;
font-size: 64px;
  &:hover{
    background: darken($color_purple, 10%);
  }
}

</style>

