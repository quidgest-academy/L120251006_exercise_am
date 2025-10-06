import { defineAsyncComponent } from 'vue'

export default {
	install: (app) => {
		app.component('QFormAccountInfo', defineAsyncComponent(() => import('@/views/shared/AccountInfo.vue')))
		app.component('QFormFr001', defineAsyncComponent(() => import('@/views/forms/FormFr001/QFormFr001.vue')))
	}
}
