<template>
  <div class="container">
    <b-form class="d-flex justify-content-around" inline>
      <label class="mr-sm-2" for="inline-form-custom-select-pref">Color</label>
      <b-form-select
        class="mb-2 mr-sm-2 mb-sm-0"
        v-model="color"
        :options="colors"
        id="inline-form-custom-select-pref"
      >
        <template v-slot:first>
          <option :value="null">Choose...</option>
        </template>
      </b-form-select>
      <!-- <b-form-group id="input-group-1" label="Color:" label-for="input-1">
        <b-form-select id="input-1" :value="color" :options="colors"></b-form-select>
      </b-form-group>-->

      <b-form-group id="input-2">
        <b-form-checkbox v-model="hasSunroof">Sunroof</b-form-checkbox>
      </b-form-group>

      <b-form-group id="input-3">
        <b-form-checkbox v-model="isFourWheelDrive">AWD</b-form-checkbox>
      </b-form-group>

      <b-form-group id="input-4">
        <b-form-checkbox v-model="hasNavigation">Navigation</b-form-checkbox>
      </b-form-group>

      <b-form-group id="input-5">
        <b-form-checkbox v-model="hasLowMiles">Low Mileages</b-form-checkbox>
      </b-form-group>

      <b-form-group id="input-6">
        <b-form-checkbox v-model="hasPowerWindows">Power Windows</b-form-checkbox>
      </b-form-group>

      <b-form-group id="input-7">
        <b-form-checkbox v-model="hasHeatedSeats">Heated Seats</b-form-checkbox>
      </b-form-group>
    </b-form>
    <button type="submit" class="btn btn-primary" @click="submit">Submit</button>
    <button type="reset" class="btn btn-danger" @click="reset">Reset</button>
    <div v-if="result" class="d-flex justify-content-around">
      <!-- {{result}} -->
      <div v-for="(item, index) in result" :key="index">
        <b-card
          :title="item.make"
          img-src="https://picsum.photos/600/300/?image=25"
          img-alt="Image"
          img-top
          tag="article"
          style="max-width: 20rem;"
          class="mb-2"
        >
          <b-card-text><b>{{item.year}} {{item.make}} {{item.color}} </b>
            <ul>
                <li v-for="(option,index) in item.description" :key="index">
                    {{option}}
                    </li>
            </ul>
            
          </b-card-text>

          <b-button href="#" variant="primary">Details</b-button>
        </b-card>
      </div>
    </div>
  </div>
</template>
<script>
import Multiselect from "vue-multiselect";
export default {
  components: { Multiselect },
  data() {
    return {
      colors: ["Red", "White", "Gray", "Silver", "Black"],
      hasSunroof: false,
      isFourWheelDrive: false,
      hasNavigation: false,
      color: null,
      hasLowMiles: false,
      hasPowerWindows: false,
      hasHeatedSeats: false,
      result: null,
      //selectedOptions:null
    };
  },
  computed:{
    // GetSelectedOptions()
    //   {
    //       var result =[];
    //       if(this.hasSunroof) result.push("Sunroof");
    //       if(this.isFourWheelDrive) result.push("AWD");
    //       if(this.hasNavigation) result.push("Navigation");
    //       if(this.hasLowMiles) result.push("Low Miles");
    //       if(this.hasPowerWindows) result.push("Power Windows");
    //       if(this.hasHeatedSeats) result.push("Heated Seats");

    //       return result;
    //   },
  },
  methods: {
    async submit() {
      var dto = {
        color: this.color,
        hasSunroof: this.hasSunroof,
        isFourWheelDrive: this.isFourWheelDrive,
        hasNavigation: this.hasNavigation,
        hasLowMiles: this.hasLowMiles,
        hasPowerWindows: this.hasPowerWindows,
        hasHeatedSeats: this.hasHeatedSeats
      };
      await this.$api
        .post("http://localhost:65165/product/postsearch", dto)
        .then(product => {
          this.result = product.data;
          
        });
    },
    
    reset() {
      var initValue = {
        hasSunroof: false,
        isFourWheelDrive: false,
        hasNavigation: false,
        color: null,
        hasLowMiles: false,
        hasPowerWindows: false,
        hasHeatedSeats: false,
        result: null,
        selectedOptions:null
      };
      Object.assign(this.$data, initValue);
    }
  }
};
</script>
<style lang="scss" scoped>
li{
    list-style-type:none;
}
</style>