<template>
    <div class="container">
        <div class="row">
            Select 
        </div>
    </div>
</template>
<script>
import Multiselect from 'vue-multiselect'
export default {
    components: { Multiselect },
    data()
    {
        return{
            colors:["Red","White","Gray","Silver","Black"],
            hasSunroof: null,
            isFourWheelDrive: null,
            hasNavigation:null,
            color:null,
            hasLowMiles:null,
            hasPowerWindows:null,
            hasHeatedSeats:null,
        }
    }
}
</script>