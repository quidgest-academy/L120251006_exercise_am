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
	]
}
