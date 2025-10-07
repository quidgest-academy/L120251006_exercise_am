import { propsConverter } from './routeUtils.js'

export default function getFormsRoutes()
{
	return [
		{
			path: '/:culture/:system/:module/form/FR_001/:mode/:id?',
			name: 'form-FR_001',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFr001/QFormFr001.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'T_001',
				humanKeyFields: ['ValEmail']
			}
		},
		{
			path: '/:culture/:system/:module/form/FR_002/:mode/:id?',
			name: 'form-FR_002',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormFr002/QFormFr002.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'T_002',
				humanKeyFields: ['ValTitle']
			}
		},
	]
}
