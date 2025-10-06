import { defineAsyncComponent } from 'vue'

export default {
	install: (app) => {
		app.component('QFormAccountInfo', defineAsyncComponent(() => import('@/views/shared/AccountInfo.vue')))
		app.component('QFormF001', defineAsyncComponent(() => import('@/views/forms/FormF001/QFormF001.vue')))
	}
}
